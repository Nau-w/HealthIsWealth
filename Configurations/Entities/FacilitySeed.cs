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
                    Location = "",
                    Name = "",
                    Price = 0.0f,
                    VenueId = 1
                }
            );
        }
    }
}
