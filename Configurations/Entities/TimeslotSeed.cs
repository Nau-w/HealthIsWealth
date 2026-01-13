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
                    StartDT = new DateTime(2026, 10, 30, 12, 0, 0),
                    EndDT = new DateTime(2026, 10, 30, 13, 0, 0),
                    FacilityId = 1
                }
            );
        }
    }
}
