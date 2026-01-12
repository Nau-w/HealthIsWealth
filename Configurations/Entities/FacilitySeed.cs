using HealthIsWealth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthIsWealth.Configurations.Entities
{
    public class FacilitySeed : IEntityTypeConfiguration<Facility>
    {
        public void Configure(EntityTypeBuilder<Facility> builder)
        {
            builder.HasData(
                new Facility
                {
                    FacilityId = 1,
                    Name = "Multipurpose Hall",
                    Location = "Hall A",
                    VenueId = 1,
                    FacilitySportId = 1
                },
                new Facility
                {
                    FacilityId = 2,
                    Name = "Multipurpose Hall",
                    Location = "Hall A",
                    VenueId = 1,
                    FacilitySportId = 2
                }
            );
        }
    }
}
