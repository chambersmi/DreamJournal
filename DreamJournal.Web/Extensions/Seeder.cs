using DreamJournal.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace DreamJournal.Web.Extensions
{
    public static class Seeder
    {
        public static async Task SeedRolesAndAdminAsync(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            foreach(var roleName in AppRoles.AllRoles)
            {
                if(!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            await SeedDefaultAdminAsync(userManager);
        }

        public static async Task SeedDefaultAdminAsync(
            UserManager<ApplicationUser> userManager)
        {
            
            string adminEmail = "mjch.admin@gmail.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if(adminUser == null)
            {
                var newAdmin = new ApplicationUser
                {
                    UserName = "MasterAdmin",
                    Email = adminEmail,
                    EmailConfirmed = true,
                    FirstName = "System",
                    LastName = "Administrator",
                    City = "Eaton Rapids",
                    ReligiousAffiliation = Domain.Enums.ReligiousAffiliationEnum.Buddhist,
                    State = Domain.Enums.StateEnum.MI,
                    Country = Domain.Enums.CountryEnum.US,
                    ZipCode = "48827"
                };

                var createAdmin = await userManager.CreateAsync(newAdmin, "P@ssword123!");

                if(createAdmin.Succeeded)
                {
                    await userManager.AddToRoleAsync(newAdmin, AppRoles.Admin);
                }
                else
                {
                    var errors = string.Join(", ", createAdmin.Errors.Select(e => e.Description));
                    Console.WriteLine("Error!\n\n" + errors);
                }
            }
        }
    }
}
