using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "f6ac0515-96ee-4efa-8c72-f138480610cb",
                    Email = "admin1@gmail.com",
                    NormalizedEmail = "ADMIN1@GMAIL.COM",
                    UserName = "admin1@gmail.com",
                    NormalizedUserName = "ADMIN1@GMAIL.COM",
                    Firstname= "Admin1",
                    Lastname= "kevin",
                    PasswordHash=hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed=true
                },
                new Employee
                {
                    Id = "d162da66-b0e3-49bb-9a4a-0863b3b19f8b",
                    Email = "user@gmail.com",
                    NormalizedEmail = "USER@GMAIL.COM",
                    UserName = "user@gmail.com",
                    NormalizedUserName = "USER@GMAIL.COM",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed=true
                });
        }
    }
}