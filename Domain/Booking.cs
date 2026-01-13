using HealthIsWealth.Data;

namespace HealthIsWealth.Domain
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string? UserId { get; set; }
        public int TimeslotId { get; set; }

        //Foreign Key
        public HealthIsWealthUser? User { get; set; }
        public Timeslot? Timeslot { get; set; }
    }
}