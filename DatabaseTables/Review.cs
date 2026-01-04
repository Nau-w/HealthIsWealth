namespace HealthIsWealth.DatabaseTables
{
    public class Review
    { 
        public int ReviewID { get; set; }
        public int Rating { get; set; }
        public string? Feedback { get; set; }
        public int UserID { get; set; }
        public int BookingID { get; set; }

    }
}
