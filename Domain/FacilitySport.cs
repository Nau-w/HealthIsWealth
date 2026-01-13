namespace HealthIsWealth.Domain
{
    public class FacilitySport
    {
        public int FacilitySportId { get; set; }
        public int SportId { get; set; }
        public int FacilityId { get; set; }

        // Navigation Property
        public Facility Facility { get; set; }
        public Sport Sport { get; set; }
    }
}
