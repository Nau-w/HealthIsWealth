namespace HealthIsWealth.Domain
{
    public class Sport
    {
        public int SportId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ThumbnailImageUrl { get; set; }

        public ICollection<FacilitySport> FacilitySports { get; set; }
    }
}
