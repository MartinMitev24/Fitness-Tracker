using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Services;
using Fitness_Tracker.Infrastructure.Data.Common;
using Fitness_Tracker.Infrastucture.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationsServices(this IServiceCollection services)
        {
            services.AddScoped<IExerciseService, ExerciseService>();
            services.AddScoped<IIntensityService, IntensityService>();
            services.AddScoped<IWorkoutService, WorkoutService>();

            return services;
        }

        public static IServiceCollection AddAplicationDBContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddAplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
            })
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }
    }
}
