using Fitness_Tracker.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fitness_Tracker.Infrastructure.Data.SeedDb
{
    internal class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
    {
        public void Configure(EntityTypeBuilder<Workout> builder)
        {
            var data = new SeedData();

            builder.HasData(data.FirstWorkout);
        }
    }
}
