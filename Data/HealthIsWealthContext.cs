using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HealthIsWealth.Data;
using HealthIsWealth.Domain;
using HealthIsWealth.Configurations.Entities;

namespace HealthIsWealth.Data
{
    public class HealthIsWealthContext(DbContextOptions<HealthIsWealthContext> options) : IdentityDbContext<HealthIsWealthUser>(options)
    {
        public DbSet<Facility> Facility { get; set; } = default!;
        public DbSet<FacilitySport> FacilitySport { get; set; } = default!;
        public DbSet<Sport> Sport { get; set; } = default!;
        public DbSet<Timeslot> Timeslot { get; set; } = default!;
        public DbSet<Venue> Venue { get; set; } = default!;
        public DbSet<Booking> Booking { get; set; } = default!;
        public DbSet<Review> Review { get; set; } = default!;
        public DbSet<FacilityImage> FacilityImage { get; set; } = default!;
        public DbSet<VenueImage> VenueImage { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new SportSeed());
            builder.ApplyConfiguration(new VenueSeed());
            builder.ApplyConfiguration(new FacilitySportSeed());
            builder.ApplyConfiguration(new FacilitySeed());
            builder.ApplyConfiguration(new TimeslotSeed());
            builder.ApplyConfiguration(new BookingSeed());
            builder.ApplyConfiguration(new ReviewSeed());
            builder.ApplyConfiguration(new FacilityImageSeed());
            builder.ApplyConfiguration(new VenueImageSeed());

        }
    }
}