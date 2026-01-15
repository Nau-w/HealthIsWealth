using HealthIsWealth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Net.Mime.MediaTypeNames;

namespace HealthIsWealth.Configurations.Entities
{
    public class FacilityImageSeed : IEntityTypeConfiguration<FacilityImage>
    {
        public void Configure(EntityTypeBuilder<FacilityImage> builder)
        {
            builder.HasData(
                new FacilityImage
                {
                    FacilityImageId = 1,
                    ImageUrl = "images/facilities/diamond_hub_gym_1.jpg",
                    FacilityId = 19
                },
                new FacilityImage
                {
                    FacilityImageId = 2,
                    ImageUrl = "images/facilities/diamond_hub_gym_2.jpg",
                    FacilityId = 19
                },
                new FacilityImage
                {
                    FacilityImageId = 3,
                    ImageUrl = "images/facilities/one_gym_1.jpg",
                    FacilityId = 3
                }
            );
        }
    }
}
