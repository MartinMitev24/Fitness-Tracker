using Fitness_Tracker.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fitness_Tracker.Infrastructure.Data.SeedDb
{
    internal class IntensityConfiguration : IEntityTypeConfiguration<Intensity>
    {
        public void Configure(EntityTypeBuilder<Intensity> builder)
        {
            var data = new SeedData();

            builder.HasData(new Intensity[] 
                {
                    data.SquatIntensity,
                    data.BicepCurlsIntensity,
                    data.TricepExetnsionsIntensity,
                    data.CableRowIntensity,
                    data.BenchPressIntensity,
                    data.ShoulderPressIntensity,
                    data.CrunchesIntensity
                });
        }
    }
}
