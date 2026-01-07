namespace HealthIsWealth.Domain
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string? UserId { get; set; }
        public int TimeslotId { get; set; }
    }
}
