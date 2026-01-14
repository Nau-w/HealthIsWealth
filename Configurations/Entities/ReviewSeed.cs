using HealthIsWealth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthIsWealth.Configurations.Entities
{
    public class ReviewSeed: IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                //new Review
                //{
                //    ReviewId = 1,
                //    Rating = 4.5f,
                //    Feedback = "Good facility venue has a lot of ammenities",
                //    BookingId = 1,
                //    UserId = "6d3d2829-89fa-4095-b0f9-0ef8e802fd69"
                //},
                //new Review
                //{
                //    ReviewId = 2,
                //    Rating = 4.0f,
                //    Feedback = "Dirty equipments but gym has alot of machines",
                //    BookingId = 2,
                //    UserId = "6d3d2829-89fa-4095-b0f9-0ef8e802fd69"
                //},
                //new Review
                //{
                //     ReviewId = 3,
                //     Rating = 5.0f,
                //     Feedback = "Best volleyball court ever",
                //     BookingId = 3,
                //     UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                //}
            );        
        }
    }
}
