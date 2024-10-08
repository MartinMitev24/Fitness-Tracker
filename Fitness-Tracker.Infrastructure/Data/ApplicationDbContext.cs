﻿using Fitness_Tracker.Infrastructure.Data.Models;
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

        DbSet<Exercise> Exercises { get; set; }

        DbSet<Intensity> intensities { get; set; }

        DbSet<Workout> Workouts { get; set; }
    }
}
