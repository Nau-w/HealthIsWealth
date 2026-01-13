namespace HealthIsWealth.Domain
{
    public class VenueImage
    {
        public int VenueImageId { get; set; }
        public string? ImageUrl { get; set; }
        public int VenueId { get; set; }

        // Navigation Properties
        public Venue Venue { get; set; }
    }
}
