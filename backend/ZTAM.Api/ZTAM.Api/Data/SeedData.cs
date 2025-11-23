using ZTAM.Api.Models;

namespace ZTAM.Api.Data
{
    public static class SeedData
    {
        public static void Initialize(ZTAMContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.Add(new User { Name = "Admin User", Email = "admin@example.com" });
            }

            if (!context.Applications.Any())
            {
                context.Applications.Add(new ApplicationEntity { Name = "Finance System" });
            }

            context.SaveChanges();
        }
    }
}