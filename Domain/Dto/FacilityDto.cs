namespace HealthIsWealth.Domain.Dto
{
    public class FacilityDto
    {
        public int FacilityId { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public float Price { get; set; }
        public ICollection<TimeslotDto> Timeslots { get; set; }
        public ICollection<SportDto> Sports { get; set; }
    }
}
