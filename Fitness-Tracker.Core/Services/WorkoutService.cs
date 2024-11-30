using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models.Intensity;
using Fitness_Tracker.Core.Models.Workout;
using Fitness_Tracker.Infrastructure.Data.Common;
using Fitness_Tracker.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Fitness_Tracker.Core.Services
{
    public class WorkoutService : IWorkoutService
    {
        private readonly IRepository _repository;
        private readonly IIntensityService _intensityService;

        public WorkoutService(IRepository repository, IIntensityService intensityService)
        {
            _repository = repository;
            _intensityService = intensityService;
        }

        public async Task<WorkoutViewModel> FindWorkout(int id)
        {
            IEnumerable<IntensityViewModel> intensitysViewModels = await IntensityViewModels();

            WorkoutViewModel workout = await _repository.AllReadOnly<Workout>()
                .Select(w => new WorkoutViewModel
                {
                    Id = w.Id,
                    Intensities = intensitysViewModels.Where(i => i.WorkoutId == id).ToList() ?? new List<IntensityViewModel>(),
                })
                .FirstAsync(w => w.Id == id);

            return workout;
        }

        public async Task<IEnumerable<WorkoutViewModel>> GetAllAsync()
        {
            IEnumerable<IntensityViewModel> intensitysModels = await IntensityViewModels();

            IEnumerable<WorkoutViewModel> workouts = await _repository.AllReadOnly<Workout>()
                .Select(w => new WorkoutViewModel
                {
                    Id = w.Id
                })
                .ToListAsync();

            foreach (WorkoutViewModel workout in workouts)
            {
                List<IntensityViewModel> intensitysViews = intensitysModels.Where(i => i.WorkoutId == workout.Id).ToList();

                workout.Intensities = intensitysViews;
            }

            return workouts;
        }

        private async Task< IEnumerable<IntensityViewModel>> IntensityViewModels()
        {
            IEnumerable<IntensityViewModel> intensitysViewModels = await _intensityService.GetAllAsync();

            return intensitysViewModels;
        }
    }
}
