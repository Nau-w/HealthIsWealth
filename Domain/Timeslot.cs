namespace HealthIsWealth.Domain
{
    public class Timeslot
    {
        public int TimeslotId { get; set; }
        public DateTime StartDT { get; set; }
        public DateTime EndDT { get; set; }
        public int FacilityId { get; set; }
        public int VenueId { get; set; }
    }
}