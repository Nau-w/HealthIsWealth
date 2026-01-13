using HealthIsWealth.Data;

namespace HealthIsWealth.Domain
{
    public class Review
    {
        public int ReviewId { get; set; }
        public float Rating { get; set; }
        public string? Feedback { get; set; }
        public int BookingId { get; set; }
        public string? UserId { get; set; }

        //Foreign Key
        public Booking? Booking { get; set; }
        public HealthIsWealthUser? User { get; set; }
    }
}