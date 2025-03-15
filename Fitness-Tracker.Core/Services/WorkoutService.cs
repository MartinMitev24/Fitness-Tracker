using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models.Athlete;
using Fitness_Tracker.Core.Models.Intensity;
using Fitness_Tracker.Core.Models.Workout;
using Fitness_Tracker.Infrastructure.Data.Common;
using Fitness_Tracker.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Fitness_Tracker.Core.Services
{
    /// <summary>
    /// Class is used to make CRUD operations for Workout entities.
    /// </summary>
    public class WorkoutService : IWorkoutService
    {
        private readonly IRepository _repository;
        private readonly IIntensityService _intensityService;

        public WorkoutService(IRepository repository, IIntensityService intensityService)
        {
            _repository = repository;
            _intensityService = intensityService;
        }

        /// <summary>
        /// Method to create a new workout.
        /// </summary>
        /// <param name="model">Receives class WorkoutFormModel.</param>
        /// <param name="athleteId">Receives integer for athlete Identifier.</param>
        /// <returns>Adds and saves new workout in database.</returns>
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

        public async Task DeleteWorkout(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<WorkoutViewModel> FindWorkout(int id)
        {
            var workout = await _repository.AllReadOnly<Workout>()
                .Where(w => w.IsDeleted == false)
                .Select(w => new WorkoutViewModel
                {
                    Id = w.Id,
                    AthleteId = w.AthleteId,
                    WorkoutType = w.WorkoutType,
                    Intensities = new List<IntensityViewModel>()
                })
                .FirstAsync(w => w.Id == id);

            var intensities = await Intensities();

            var intensitiesForWorkout = intensities.Where(i => i.WorkoutId == workout.Id);
                
            if (intensitiesForWorkout.Any())
            {
                workout.Intensities = intensitiesForWorkout;
            }

            return workout;
        }

        /// <summary>
        /// Method to retreive all workout entities of an athlete from database.
        /// </summary>
        /// <param name="athleteId">Receives integer for athlete Identifier.</param>
        /// <returns>List of all workouts of an athlete.</returns>
        public async Task<IEnumerable<WorkoutViewModel>> GetAllAsync(int athleteId)
        {
            var intensities = await Intensities();

            var model = await _repository.AllReadOnly<Workout>()
                .Where(w => w.AthleteId == athleteId && w.IsDeleted == false)
                .Select(x => new WorkoutViewModel 
                {
                    Id = x.Id,
                    WorkoutType = x.WorkoutType,
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

        /// <summary>
        /// Method to retreive current athlete identifier.
        /// </summary>
        /// <param name="userId">Receives string for user identifier.</param>
        /// <returns>Integer for athlete identifier.</returns>
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

        /// <summary>
        /// Method to retreive exercises identifiers, names and muscle group.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ExerciseToChooseViewModel>> GetExerciseToChoose()
        {
            var exercises = await _repository.AllReadOnly<Exercise>()
                .Where(e => e.IsDeleted == false)
                .Select(x => new ExerciseToChooseViewModel
                {
                    Id = x.Id,
                    Name = x.ExerciseName,
                    MuscleType = x.TargetMuscleGroup.ToString()
                })
                .ToListAsync();

            return exercises;
        }

        /// <summary>
        /// Private method to retreive all intensities.
        /// </summary>
        /// <returns>List of IntensitiyViewModels.</returns>
        private async Task<IEnumerable<IntensityViewModel>> Intensities()
        {
            var model = await _intensityService.GetAllAsync();

            return model;
        }
    }
}
