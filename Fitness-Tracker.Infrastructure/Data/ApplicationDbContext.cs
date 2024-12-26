using Fitness_Tracker.Infrastructure.Data.Models;
using Fitness_Tracker.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fitness_Tracker.Infrastucture.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new AthleteConfiguration());
            builder.ApplyConfiguration(new ExerciseConfiguration());
            builder.ApplyConfiguration(new WorkoutConfiguration());
            builder.ApplyConfiguration(new IntensityConfiguration());

            base.OnModelCreating(builder);
        }

        DbSet<Exercise> Exercises { get; set; } = null!;

        DbSet<Intensity> Intensities { get; set; } = null!;

        DbSet<Workout> Workouts { get; set; } = null!;

        DbSet<Athlete> Athletes { get; set; } = null!;
    }
}
