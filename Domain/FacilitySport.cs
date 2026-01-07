namespace HealthIsWealth.Domain
{
    public class FacilitySport
    {
        public int FacilitySportId { get; set; }
        public int SportId { get; set; }
        public int FacilityId { get; set; }
        public int VenueId { get; set; }

        //Foreign Keys
        public Sport? Sport { get; set; }
        public Facility? Facility { get; set; }
        public Venue? Venue { get; set; }
    }
}
