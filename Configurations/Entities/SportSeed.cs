using HealthIsWealth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthIsWealth.Configurations.Entities
{
    public class SportSeed: IEntityTypeConfiguration<Sport>
    {
        public void Configure(EntityTypeBuilder<Sport> builder)
        {
            builder.HasData
            (
                new Sport
                {
                    SportId = 1,
                    Name = "Basketball",
                    Description = "A fun sport, enjoyable by many and with many formats. For your next game, book a court today.",
                    ThumbnailImageUrl = "images/sports/basketball.jpg"
                },
                new Sport
                {
                    SportId = 2,
                    Name = "Badminton",
                    Description = "An exciting racquet sport, enjoyable by all. Get your game on and book a court today.",
                    ThumbnailImageUrl = "images/sports/badminton.jpg"
                },
                new Sport
                {
                    SportId = 3,
                    Name = "Tennis",
                    Description = "An enjoyable racquet sport with strategy and skill. Play with a friend and book a court today.",
                    ThumbnailImageUrl = "images/sports/tennis.jpg"
                },
                new Sport
                {
                    SportId = 4,
                    Name = "Swimming",
                    Description = "A great sport for both fun and exercise. Cool down in the warm weather and book a pool today.",
                    ThumbnailImageUrl = "images/sports/swimming.jpg"
                },
                new Sport
                {
                    SportId = 5,
                    Name = "Gym",
                    Description = "A gym is a good place to concentrate and workout. Find a space to train with us today.",
                    ThumbnailImageUrl = "images/sports/gym.jpg"
                }
            );
        }
    }
}
