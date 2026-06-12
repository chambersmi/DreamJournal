using DreamJournal.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DreamJournal.Infrastructure.Identity
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        public DbSet<DreamEntity> DreamEntities { get; set; }
        public DbSet<SongReference> SongReferences { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            // Used for storing enum MI in database rather than 21
            builder.Entity<ApplicationUser>()
                .Property(u => u.State)
                .HasConversion<string>()
                .HasMaxLength(2);

            builder.Entity<ApplicationUser>()
                .Property(u => u.Country)
                .HasConversion<string>()
                .HasMaxLength(50);


            builder.Entity<ApplicationUser>()
                .Property(u => u.ReligiousAffiliation)
                .HasConversion<string>()
                .HasMaxLength(30);

            // Force everything to uppercase
            foreach(var entityType in builder.Model.GetEntityTypes())
            {
                foreach(var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(string) && !property.IsKey())
                    {
                        property.SetValueConverter(new Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter<string, string>(
                            v => v != null ? v.ToUpper() : null!, 
                            v => v
                        ));
                    }
                }
            }
        }
    }

    
    

}
