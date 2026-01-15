using HealthIsWealth.Data;
using HealthIsWealth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthIsWealth.Configurations.Entities
{
    public class VenueSeed : IEntityTypeConfiguration<Venue>
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.HasData(
                new Venue
                {
                    VenueId = 1,
                    Name = "One Gym",
                    Address = "211 Jurong East Street 21, Block 211, Singapore",
                    PostalCode = "600021",
                    ThumbnailImageUrl = "images/venues/one_gym_0.jpg",
                    UnitNumber = "#21-234"
                },
                new Venue
                {
                    VenueId = 2,
                    Name = "Court Complex",
                    Address = "57 Lor. 5 Toa Payoh, Block 57",
                    PostalCode = "310057",
                    ThumbnailImageUrl = "images/venues/court_complex_0.jpg",
                    UnitNumber = "#57-575"
                },
                new Venue
                {
                    VenueId = 3,
                    Name = "Pool Space",
                    Address = "200 Commonwealth Ave W",
                    PostalCode = "138677",
                    ThumbnailImageUrl = "images/venues/pool_space_0.jpg",
                    UnitNumber = "32"
                },
                new Venue
                {
                    VenueId = 4,
                    Name = "Universe Sports",
                    Address = "33 Yio Chu Kang Rd",
                    PostalCode = "545677",
                    ThumbnailImageUrl = "images/venues/universe_sports_0.jpg",
                    UnitNumber = ""
                },
                new Venue
                {
                    VenueId = 5,
                    Name = "Diamond Hub",
                    Address = "1 Choa Chu Kang Street 53",
                    PostalCode = "689236",
                    ThumbnailImageUrl = "images/venues/diamond_hub_0.jpg",
                    UnitNumber = ""
                }
            );
        }
    }
}

