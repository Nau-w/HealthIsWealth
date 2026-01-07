using HealthIsWealth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthIsWealth.Configurations.Entities
{
    public class FacilitySportSeed : IEntityTypeConfiguration<FacilitySport>
    {
        public void Configure(EntityTypeBuilder<FacilitySport> builder)
        {
            builder.HasData
            (
                new FacilitySport
                {
                    FacilitySportId = 1,
                    SportId = 1,
                    FacilityId = 1,
                    VenueId = 1
                }
            );
        }
    }
}
