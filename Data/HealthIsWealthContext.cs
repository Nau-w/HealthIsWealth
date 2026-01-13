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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<FacilitySport>() //added to fix cascade delete issue from Venue to FacilitySport
                .HasOne(fs => fs.Venue)
                .WithMany()
                .HasForeignKey(fs => fs.VenueId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Timeslot>() //added to fix cascade delete issue from Venue to Timeslot
                .HasOne(ts => ts.Venue)
                .WithMany()
                .HasForeignKey(ts => ts.VenueId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new SportSeed());
            builder.ApplyConfiguration(new FacilitySportSeed());
            builder.ApplyConfiguration(new FacilitySeed());
            builder.ApplyConfiguration(new VenueSeed());
            builder.ApplyConfiguration(new TimeslotSeed());
            builder.ApplyConfiguration(new BookingSeed());
            builder.ApplyConfiguration(new ReviewSeed());
            
            
            

        }
    }
}