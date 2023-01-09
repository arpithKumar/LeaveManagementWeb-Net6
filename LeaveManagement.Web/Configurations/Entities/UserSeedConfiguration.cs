using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hash = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "a17db9f9-59db-4a6d-aa79-b6151f2e764d",
                    Email = "arpithk3@gmail.com",
                    NormalizedEmail = "ARPITHK3@GMAIL.COM",
                    NormalizedUserName = "ARPITHK3@GMAIL.COM",
                    UserName = "arpithk3@gmail.com",
                    FirstName = "Arpith",
                    LastName = "Dubey",
                    PasswordHash = hash.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }
                );
        }
    }
}