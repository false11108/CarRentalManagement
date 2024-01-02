using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
            },
            new IdentityUserRole<string>
            {
                RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                UserId = "ee642944-ea4e-4195-971d-c843ffc4d6a6"
            },
            new IdentityUserRole<string>
            {
                RoleId = "5ee3d4ea-b945-4a86-ae24-fd7214807f04",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
            }
            );
        }
    }
}