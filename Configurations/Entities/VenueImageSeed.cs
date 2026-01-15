using HealthIsWealth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthIsWealth.Configurations.Entities
{
    public class VenueImageSeed : IEntityTypeConfiguration<VenueImage>
    {
        public void Configure(EntityTypeBuilder<VenueImage> builder)
        {
            builder.HasData(
                new VenueImage
                {
                    VenueImageId = 1,
                    ImageUrl = "images/venues/pool_space_1.jpg",
                    VenueId = 3
                },
                new VenueImage
                {
                    VenueImageId = 2,
                    ImageUrl = "images/venues/pool_space_2.jpg",
                    VenueId = 3
                },
                new VenueImage
                {
                    VenueImageId = 3,
                    ImageUrl = "images/venues/universe_sports_1.jpg",
                    VenueId = 4
                },
                new VenueImage
                {
                    VenueImageId = 4,
                    ImageUrl = "images/venues/diamond_hub_1.jpg",
                    VenueId = 5
                }
            );
        }
    }
}
