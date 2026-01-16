using HealthIsWealth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthIsWealth.Configurations.Entities
{
    public class TimeslotSeed : IEntityTypeConfiguration<Timeslot>
    {
        public void Configure(EntityTypeBuilder<Timeslot> builder)
        {
            builder.HasData(
                new Timeslot
                {
                    TimeslotId = 1,
                    StartDT = new DateTime(2026, 1, 14, 13, 0, 0),
                    EndDT = new DateTime(2026, 1, 14, 15, 0, 0),
                    FacilityId = 1
                }, 
                new Timeslot
                {
                    TimeslotId = 2,
                    StartDT = new DateTime(2024, 7, 1, 10, 0, 0),
                    EndDT = new DateTime(2024, 7, 1, 11, 0, 0),
                    FacilityId = 2,
                },
                new Timeslot
                {
                    TimeslotId = 3,
                    StartDT = new DateTime(2024, 7, 1, 11, 0, 0),
                    EndDT = new DateTime(2024, 7, 1, 12, 0, 0),
                    FacilityId = 2,
                }
            );
        }
    }
}
