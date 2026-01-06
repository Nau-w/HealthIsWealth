using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HealthIsWealth.Domain;

namespace HealthIsWealth.Data
{
    public class HealthIsWealthContext : DbContext
    {
        public HealthIsWealthContext (DbContextOptions<HealthIsWealthContext> options)
            : base(options)
        {
        }

        public DbSet<HealthIsWealth.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<HealthIsWealth.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<HealthIsWealth.Domain.Facility> Facility { get; set; } = default!;
        public DbSet<HealthIsWealth.Domain.FacilitySport> FacilitySport { get; set; } = default!;
        public DbSet<HealthIsWealth.Domain.Review> Review { get; set; } = default!;
        public DbSet<HealthIsWealth.Domain.Sport> Sport { get; set; } = default!;
        public DbSet<HealthIsWealth.Domain.Timeslot> Timeslot { get; set; } = default!;
        public DbSet<HealthIsWealth.Domain.Venue> Venue { get; set; } = default!;
    }
}
