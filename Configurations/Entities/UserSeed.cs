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
                    Email = "test1@gmail.com",
                    NormalizedEmail = "TEST1@GMAIL.COM",
                    FirstName = "test",
                    LastName = "1",
                    UserName = "test1@gmail.com",
                    NormalizedUserName = "TEST1@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true,
                    ProfilePictureUrl = "/images/ProfilePicture/backgroundImage.jpg"

                },
                new HealthIsWealthUser
                {
                    Id = "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                    Email = "test2@gmail.com",
                    NormalizedEmail = "TEST2@GMAIL.COM",
                    FirstName = "test",
                    LastName = "2",
                    UserName = "test2@gmail.com",
                    NormalizedUserName = "TEST2@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true,
                    ProfilePictureUrl = "/images/ProfilePicture/Dog Icon.jpeg"
                }
            );
        }
    }
}