using HealthIsWealth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics;

namespace HealthIsWealth.Configurations.Entities
{
    public class FacilitySportSeed : IEntityTypeConfiguration<FacilitySport>
    {
        public void Configure(EntityTypeBuilder<FacilitySport> builder)
        {
            List<int> basketball_facility_ids = [6, 11, 12, 13, 14];
            List<int> badminton_facility_ids = [4, 5, 8, 9, 10, 17, 18];
            List<int> tennis_facility_ids = [4, 5, 8, 9, 10];
            List<int> swimming_facility_ids = [7, 15, 16];
            List<int> gym_facility_ids = [1,2,3,19];
            List<List<int>> sports_facility_ids = [basketball_facility_ids, 
                badminton_facility_ids, tennis_facility_ids, swimming_facility_ids,  gym_facility_ids];

            int id = 0;
            int sport_id = 0;
            foreach (List<int> sport_facility_ids in sports_facility_ids)
            {
                sport_id++;
                foreach (int facility_id in sport_facility_ids)
                {
                    id++;
                    builder.HasData(
                        new FacilitySport
                        {
                            FacilitySportId = id,
                            FacilityId = facility_id,
                            SportId = sport_id
                        }
                    );
                }
            }
        }
    }
}
