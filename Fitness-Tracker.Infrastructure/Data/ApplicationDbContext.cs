using Fitness_Tracker.Infrastructure.Data.Models;
using Fitness_Tracker.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fitness_Tracker.Infrastucture.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ExerciseConfiguration());

            base.OnModelCreating(builder);
        }

        DbSet<Exercise> Exercises { get; set; } = null!;

        DbSet<Intensity> intensities { get; set; } = null!;

        DbSet<Workout> Workouts { get; set; } = null!;
    }
}
