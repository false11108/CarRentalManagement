using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            },
            new ApplicationUser
            {
                Id = "ee642944-ea4e-4195-971d-c843ffc4d6a6",
                Email = "admin1@localhost.com",
                NormalizedEmail = "ADMIN1@LOCALHOST.COM",
                FirstName = "Admin1",
                LastName = "User1",
                UserName = "admin1@localhost.com",
                NormalizedUserName = "ADMIN1@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword2")
            },
            new ApplicationUser
            {
                Id = "0d76c4ee-aad6-460f-844b-cc1aabccbec0",
                Email = "admin2@localhost.com",
                NormalizedEmail = "ADMIN2@LOCALHOST.COM",
                FirstName = "Admin2",
                LastName = "User2",
                UserName = "admin2@localhost.com",
                NormalizedUserName = "ADMIN2@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword3")
            }
            );
        }
    }
}