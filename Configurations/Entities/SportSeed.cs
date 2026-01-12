using HealthIsWealth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HealthIsWealth.Configurations.Entities
{
    public class SportSeed: IEntityTypeConfiguration<Sport>
    {
        public void Configure(EntityTypeBuilder<Sport> builder)
        {
            builder.HasData
            (
                new Sport
                { 
                    SportId = 1,
                    Name = "Badminton",
                    Description = "Badminton is a fast-paced racket sport where players hit a shuttlecock (or birdie) over a net, aiming to land it in the opponent's court, playable in singles (one-on-one) or doubles (two-on-two)."
                },
                new Sport
                {
                    SportId = 2,
                    Name = "Basketball",
                    Description = "Basketball is a fast-paced, popular team sport where two teams of five players score by shooting a ball through an elevated hoop, using dribbling, passing, and shooting on a rectangular court, aiming to outscore opponents within timed periods."
                }
            );
        }
    }
}
