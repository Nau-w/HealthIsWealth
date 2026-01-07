using HealthIsWealth.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace HealthIsWealth.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<HealthIsWealthUser>
    {
        public void Configure(EntityTypeBuilder<HealthIsWealthUser> builder)
        {
            var hasher = new PasswordHasher<HealthIsWealthUser>();
            builder.HasData(
                new HealthIsWealthUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "test1@localhost.com",
                    NormalizedEmail = "TEST1@LOCALHOST.COM",
                    FirstName = "test",
                    LastName = "1",
                    UserName = "test1@localhost.com",
                    NormalizedUserName = "TEST1@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login
                }
            );
        }
    }
}
