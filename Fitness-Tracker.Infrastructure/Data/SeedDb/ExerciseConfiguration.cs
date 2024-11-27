using Fitness_Tracker.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fitness_Tracker.Infrastructure.Data.SeedDb
{
    internal class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            var data = new SeedData();

            builder.HasData(new Exercise[] { data.Squats, data.BicepCurls, data.TricepExetnsions, data.CableRow, data.BenchPress, data.ShoulderPress, data.Crunches, data.DynamicStretching });
        }
    }
}
