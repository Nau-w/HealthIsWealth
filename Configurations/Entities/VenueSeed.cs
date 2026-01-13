using HealthIsWealth.Data;
using HealthIsWealth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthIsWealth.Configurations.Entities
{
    public class VenueSeed : IEntityTypeConfiguration<Venue>
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.HasData(
                new Venue
                {
                    VenueId = 1,
                    Address = "Sambawang",
                    PostalCode = "123456",
                    UnitNumber = "01-1234",
                }
            );
        }
    }
}

