using HealthIsWealth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthIsWealth.Configurations.Entities
{
    public class BookingSeed : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasData(
                //new Booking
                //{
                //    BookingId = 1,
                //    UserId = "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                //    TimeslotId = 1
                //},
                //new Booking
                //{
                //    BookingId = 2,
                //    UserId = "6d3d2829-89fa-4095-b0f9-0ef8e802fd69",
                //    TimeslotId = 2
                //},
                //new Booking
                //{
                //    BookingId = 3,
                //    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4",
                //    TimeslotId = 3
                //}
            );
        }
    }
}
