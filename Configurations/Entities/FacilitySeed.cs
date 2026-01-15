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
                    Name = "The Gym 1",
                    Location = "01-01",
                    Price = 5.0f,
                    ThumbnailImageUrl = "images/facilities/one_gym_0.jpg",
                    VenueId = 1                    
                },
                new Facility
                {
                    FacilityId = 2,
                    Name = "The Gym 2",
                    Location = "01-02",
                    Price = 5.0f,
                    ThumbnailImageUrl = "images/facilities/one_gym_0.jpg",
                    VenueId = 1
                },
                new Facility
                {
                    FacilityId = 3,
                    Name = "The Gym Premium",
                    Location = "02-01",
                    Price = 10.0f,
                    ThumbnailImageUrl = "images/facilities/one_gym_0.jpg",
                    VenueId = 1
                },
                new Facility
                {
                    FacilityId = 4,
                    Name = "Court 1",
                    Location = "Level 2 MPH",
                    Price = 4.0f,
                    ThumbnailImageUrl = "images/facilities/court_complex_0.jpg",
                    VenueId = 2
                },
                new Facility
                {
                    FacilityId = 5,
                    Name = "Court 2",
                    Location = "Level 2 MPH",
                    Price = 4.0f,
                    ThumbnailImageUrl = "images/facilities/court_complex_0.jpg",
                    VenueId = 2
                },
                new Facility
                {
                    FacilityId = 6,
                    Name = "Basketball Court",
                    Location = "Level 2 MPH",
                    Price = 6.0f,
                    ThumbnailImageUrl = "images/facilities/court_complex_bb_court.jpg",
                    VenueId = 2
                },
                new Facility
                {
                    FacilityId = 7,
                    Name = "Private Pool",
                    Location = "",
                    Price = 8.0f,
                    ThumbnailImageUrl = "images/facilities/pool_space_0.jpg",
                    VenueId = 3
                },
                new Facility
                {
                    FacilityId = 8,
                    Name = "Court 1",
                    Location = "Level 3 MPH",
                    Price = 5.0f,
                    ThumbnailImageUrl = "images/facilities/universe_sports_court.jpg",
                    VenueId = 4
                }, 
                new Facility
                {
                    FacilityId = 9,
                    Name = "Court 2",
                    Location = "Level 3 MPH",
                    Price = 5.0f,
                    ThumbnailImageUrl = "images/facilities/universe_sports_court.jpg",
                    VenueId = 4
                },
                new Facility
                {
                    FacilityId = 10,
                    Name = "Court 3",
                    Location = "Level 3 MPH",
                    Price = 5.0f,
                    ThumbnailImageUrl = "images/facilities/universe_sports_court.jpg",
                    VenueId = 4
                },
                new Facility
                {
                    FacilityId = 11,
                    Name = "Basketball Court 1",
                    Location = "Level 2 MPH",
                    Price = 8.0f,
                    ThumbnailImageUrl = "images/facilities/universe_sports_bb_court.jpg",
                    VenueId = 4
                },
                new Facility
                {
                    FacilityId = 12,
                    Name = "Basketball Court 2",
                    Location = "Level 2 MPH",
                    Price = 8.0f,
                    ThumbnailImageUrl = "images/facilities/universe_sports_bb_court.jpg",
                    VenueId = 4
                },
                new Facility
                {
                    FacilityId = 13,
                    Name = "Basketball Court 1",
                    Location = "Ruby Wing 01-01",
                    Price = 8.0f,
                    ThumbnailImageUrl = "images/facilities/diamond_hub_bb_court.jpg",
                    VenueId = 5
                }, 
                new Facility
                {
                    FacilityId = 14,
                    Name = "Basketball Court 2",
                    Location = "Ruby Wing 01-02",
                    Price = 8.0f,
                    ThumbnailImageUrl = "images/facilities/diamond_hub_bb_court.jpg",
                    VenueId = 5
                },
                new Facility
                {
                    FacilityId = 15,
                    Name = "Luxury Pool 1",
                    Location = "Sapphire Wing 01-01",
                    Price = 32.0f,
                    ThumbnailImageUrl = "images/facilities/diamond_hub_pool.jpg",
                    VenueId = 5
                },
                new Facility
                {
                    FacilityId = 16,
                    Name = "Luxury Pool 2",
                    Location = "Sapphire Wing 01-01",
                    Price = 32.0f,
                    ThumbnailImageUrl = "images/facilities/diamond_hub_pool.jpg",
                    VenueId = 5
                },
                new Facility
                {
                    FacilityId = 17,
                    Name = "Badminton Court 1",
                    Location = "Emerald Wing 01-01",
                    Price = 10.0f,
                    ThumbnailImageUrl = "images/facilities/diamond_hub_court.jpg",
                    VenueId = 5
                },
                new Facility
                {
                    FacilityId = 18,
                    Name = "Badminton Court 2",
                    Location = "Emerald Wing 01-01",
                    Price = 10.0f,
                    ThumbnailImageUrl = "images/facilities/diamond_hub_court.jpg",
                    VenueId = 5
                },
                new Facility
                {
                    FacilityId = 19,
                    Name = "Luxury Private Gym",
                    Location = "Gold Wing 01-01",
                    Price = 20.0f,
                    ThumbnailImageUrl = "images/facilities/diamond_hub_gym.jpg",
                    VenueId = 5
                }
            );
        }
    }
}
