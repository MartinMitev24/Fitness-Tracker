using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models.Athlete;
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

        public async Task CreateWorkout(WorkoutFormModel model, int athleteId)
        {
            Workout workout = new Workout();

            List<Intensity> intensityList = new List<Intensity>();

            foreach (var intensityInModel in model.Intensities)
            {
                var intensity = new Intensity()
                {
                    ExerciseId = intensityInModel.ExerciseId,
                    LiftedWeight = intensityInModel.Weight,
                    Reps = intensityInModel.Reps,
                    AvarageTimePerSet = intensityInModel.Time,
                    Sets = intensityInModel.Sets
                };

                intensityList.Add(intensity);
            }

            workout.Intensities = intensityList;

            workout.AthleteId = athleteId;

            await _repository.AddAsync(workout);
            await _repository.SaveAsync();
        }

        public Task<WorkoutViewModel> FindWorkout(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<WorkoutViewModel>> GetAllAsync(int athleteId)
        {
            var intensities = await Intensities();

            var model = await _repository.AllReadOnly<Workout>()
                .Where(w => w.AthleteId == athleteId)
                .AsNoTracking()
                .Select(x => new WorkoutViewModel 
                {
                    Id = x.Id,
                    AthleteId = x.AthleteId,
                })
                .ToListAsync();

            foreach (var workout in model)
            {
                var intensitiesForWorkout = intensities.Where(i => i.WorkoutId == workout.Id);

                workout.Intensities = intensitiesForWorkout;
            }

            return model;
        }

        public async Task<int> GetAthleteId(string userId)
        {
            var athlete = await _repository.AllReadOnly<Athlete>()
                .Select(x => new AthleteViewModel
                {
                    Id = x.Id,
                    UserId = x.UserID
                })
                .FirstAsync(a => a.UserId == userId);

            return athlete.Id;
        }

        public async Task<IEnumerable<ExerciseToChooseViewModel>> GetExerciseToChoose()
        {
            var exercises = await _repository.AllReadOnly<Exercise>()
                .AsNoTracking()
                .Select(x => new ExerciseToChooseViewModel
                {
                    Id = x.Id,
                    Name = x.ExerciseName,
                    MuscleType = x.TargetMuscleGroup.ToString()
                })
                .ToListAsync();

            return exercises;
        }

        private async Task<IEnumerable<IntensityViewModel>> Intensities()
        {
            var model = await _intensityService.GetAllAsync();

            return model;
        }
    }
}
