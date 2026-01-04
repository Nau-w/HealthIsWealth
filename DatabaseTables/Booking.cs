namespace HealthIsWealth.DatabaseTables
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public int TimeslotID { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.UtcNow;
    }
}
