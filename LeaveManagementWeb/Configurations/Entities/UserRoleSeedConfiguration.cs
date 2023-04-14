using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;

namespace LeaveManagementWeb.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "a6ac1256-96ee-4efa-8c92-f138480610af",
                    UserId = "f6ac0515-96ee-4efa-8c72-f138480610cb"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "f6ac0515-96ee-4efa-8c72-a290380610ea",
                    UserId = "d162da66-b0e3-49bb-9a4a-0863b3b19f8b"
                }
            );
        }
    }
}