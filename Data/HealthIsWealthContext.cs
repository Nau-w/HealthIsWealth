using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HealthIsWealth.Data;
using HealthIsWealth.Domain;

namespace HealthIsWealth.Data
{
    public class HealthIsWealthContext(DbContextOptions<HealthIsWealthContext> options) : IdentityDbContext<HealthIsWealthUser>(options)
    {
        public DbSet<Customer> Customer { get; set; } = default!;
        public DbSet<Booking> Booking { get; set; } = default!;
        public DbSet<Facility> Facility { get; set; } = default!;
        public DbSet<FacilitySport> FacilitySport { get; set; } = default!;
        public DbSet<Review> Review { get; set; } = default!;
        public DbSet<Sport> Sport { get; set; } = default!;
        public DbSet<Timeslot> Timeslot { get; set; } = default!;
        public DbSet<Venue> Venue { get; set; } = default!;
    }
}
