namespace HealthIsWealth.Domain.Dto
{
    public class VenueDto
    {
        public int VenueId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PostalCode { get; set; }
        public string? UnitNumber { get; set; }
        public ICollection<FacilityDto> Facilities { get; set; }
    }
}
