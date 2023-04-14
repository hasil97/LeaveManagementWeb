using LeaveManagementWeb.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Xml.Linq;

namespace LeaveManagementWeb.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "a6ac1256-96ee-4efa-8c92-f138480610af",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "f6ac0515-96ee-4efa-8c72-a290380610ea",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper(),
                }
            );
        }
    }
}