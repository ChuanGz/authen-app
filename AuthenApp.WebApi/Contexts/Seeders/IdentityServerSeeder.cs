using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public static class IdentityServerSeeder
{
    private static void SeedUsers(ModelBuilder builder)
    {
        PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
        List<ApplicationUser> users = [
            new ApplicationUser()
            {
                Id = "f736cc9f-da49-4006-bed1-6f49f10bde81",
                UserName = "Olih System",
                Email = "olih.system@olih.com",
                LockoutEnabled = true,
                PhoneNumber = "1234567890"
            },
            new ApplicationUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "Olih Admin",
                Email = "olih.admin@olih.com",
                LockoutEnabled = true,
                PhoneNumber = "1234567890"
            },
            new ApplicationUser()
            {
                Id = "18982e3a-f76d-4985-90bc-461341351f77",
                UserName = "Kendy",
                Email = "kendy@olih.com",
                LockoutEnabled = true,
                PhoneNumber = "1234567890"
            }
        ];
        users.ForEach(usr => passwordHasher.HashPassword(usr, "123qwe!@#"));
        builder.Entity<ApplicationUser>().HasData(users);
    }
    private static void SeedRoles(ModelBuilder builder)
    {
        builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "3d5b1647-09c5-463d-8991-fc88c37654ba", Name = "System Admin", ConcurrencyStamp = DateTime.UtcNow.Ticks.ToString(), NormalizedName = "System Admin" },
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Portal Admin", ConcurrencyStamp = DateTime.UtcNow.Ticks.ToString(), NormalizedName = "Portal Admin" },
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "Normal Member", ConcurrencyStamp = DateTime.UtcNow.Ticks.ToString(), NormalizedName = "Normal Member" }
                );
    }
    private static void SeedUserRoles(ModelBuilder builder)
    {
        builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "3d5b1647-09c5-463d-8991-fc88c37654ba", UserId = "f736cc9f-da49-4006-bed1-6f49f10bde81" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5" },
                new IdentityUserRole<string>() { RoleId = "3d5b1647-09c5-463d-8991-fc88c37654ba", UserId = "18982e3a-f76d-4985-90bc-461341351f77" },
                new IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "18982e3a-f76d-4985-90bc-461341351f77" },
                new IdentityUserRole<string>() { RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330", UserId = "18982e3a-f76d-4985-90bc-461341351f77" }
                );
    }

    public static void DataSeeder(ModelBuilder builder)
    {
        SeedUsers(builder);
        SeedRoles(builder);
        SeedUserRoles(builder);
    }
}