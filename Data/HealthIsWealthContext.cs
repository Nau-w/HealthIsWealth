using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HealthIsWealth.DatabaseTables;

namespace HealthIsWealth.Data
{
    public class HealthIsWealthContext : DbContext
    {
        public HealthIsWealthContext (DbContextOptions<HealthIsWealthContext> options)
            : base(options)
        {
        }

        public DbSet<HealthIsWealth.DatabaseTables.Venue> Venue { get; set; } = default!;
        public DbSet<HealthIsWealth.DatabaseTables.User> User { get; set; } = default!;
        public DbSet<HealthIsWealth.DatabaseTables.Timeslot> Timeslot { get; set; } = default!;
        public DbSet<HealthIsWealth.DatabaseTables.Sport> Sport { get; set; } = default!;
        public DbSet<HealthIsWealth.DatabaseTables.Review> Review { get; set; } = default!;
        public DbSet<HealthIsWealth.DatabaseTables.FacilitySport> FacilitySport { get; set; } = default!;
        public DbSet<HealthIsWealth.DatabaseTables.Facility> Facility { get; set; } = default!;
        public DbSet<HealthIsWealth.DatabaseTables.Booking> Booking { get; set; } = default!;
    }
}
