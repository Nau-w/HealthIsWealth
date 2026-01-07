using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HealthIsWealth.DatabaseTables
{
    public class Venue
    {
        public int VenueID { get; set; }
        public string? Address { get; set; }
        public string? PostalCode { get; set; }
        public string? UnitNumber { get; set; }
        public string? ImageSource { get; set; }

        //Navigation Properties

        public ICollection<Facility> Facilities { get; set; }

    }
}
    