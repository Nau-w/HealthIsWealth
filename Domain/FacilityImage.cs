namespace HealthIsWealth.Domain
{
    public class FacilityImage
    {
        public int FacilityImageId { get; set; }
        public string? ImageUrl { get; set; }
        public int FacilityId { get; set; }

        // Navigation Properties
        public Facility Facility { get; set; }
    }
}
