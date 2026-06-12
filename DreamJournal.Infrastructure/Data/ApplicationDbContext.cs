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
    }
    

}
