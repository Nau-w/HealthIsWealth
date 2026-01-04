namespace HealthIsWealth.DatabaseTables
{
    public class Timeslot
    {
        public int TimeslotID { get; set; }
        public DateTime StartDT { get; set; }
        public DateTime EndDT { get; set; }
        public int FacilityID { get; set; }
        public int VenueID { get; set; }
    }
}
