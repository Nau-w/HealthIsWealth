namespace HealthIsWealth.Domain.Dto
{
    public class FacilityDto
    {
        public int FacilityId { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public float Price { get; set; }
        public ICollection<Timeslot> Timeslots { get; set; }
        public ICollection<Sport> Sports { get; set; }
    }
}
