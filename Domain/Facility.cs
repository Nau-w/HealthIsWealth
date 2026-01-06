namespace HealthIsWealth.Domain
{
    public class Facility
    {
        public int FacilityId { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public int VenueId { get; set; }
        public float Price { get; set; }
    }
}