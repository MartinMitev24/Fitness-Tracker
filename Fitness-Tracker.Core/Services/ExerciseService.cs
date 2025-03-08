using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models.Exercise;
using Fitness_Tracker.Infrastructure.Data.Common;
using Fitness_Tracker.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Fitness_Tracker.Core.Services
{
    /// <summary>
    /// Class is used for CRUD operations of exercise data set.
    /// 
    /// Note: Delete operations is not implemented.
    /// </summary>
    public class ExerciseService : IExerciseService
    {
        private readonly IRepository _repository;

        public ExerciseService(IRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Method to retreive all entities from database.
        /// </summary>
        /// <returns>List of ExerciseViewModel.</returns>
        public async Task<IEnumerable<ExerciseViewModel>> GetAllAsync()
        {
            return await _repository.All<Exercise>()
                .Select(e => new ExerciseViewModel
                {
                    Id = e.Id,
                    ExerciseName = e.ExerciseName,
                    ExerciseDescription = e.ExerciseDescription,
                    TargetMuscleGroup = e.TargetMuscleGroup,
                    ImageUrl = e.ImageUrl,
                })
                .ToListAsync();
        }

        /// <summary>
        /// Method is used for viewing exerces data.
        /// </summary>
        /// <param name="id">Receives integer for Exercise Idntifier</param>
        /// <returns>ExerciseViewModel</returns>
        public async Task<ExerciseViewModel> FindExercise(int id)
        {
            var exercise = await _repository.AllReadOnly<Exercise>()
                .Select(e => new ExerciseViewModel
                {
                    Id = e.Id,
                    ExerciseName = e.ExerciseName,
                    ExerciseDescription = e.ExerciseDescription,
                    TargetMuscleGroup = e.TargetMuscleGroup,
                    ImageUrl = e.ImageUrl
                })
                .FirstOrDefaultAsync(e => e.Id == id);

            return exercise;
        }

        /// <summary>
        /// Method is used viewing when updating exercise data.
        /// </summary>
        /// <param name="id">Receives integer for Exercise Idntifier</param>
        /// <returns>EditExerciseViewModel</returns>
        public async Task<EditExerciseFormModel> GetExercise(int id)
        {
            var exercise = await _repository.AllReadOnly<Exercise>()
                .Select(e => new EditExerciseFormModel
                {
                    Id = e.Id,
                    ExerciseName = e.ExerciseName,
                    ExerciseNewName = e.ExerciseName,
                    ExerciseDescription = e.ExerciseDescription,
                    ExerciseNewDescription = e.ExerciseDescription,
                    TargetMuscleGroup = e.TargetMuscleGroup,
                    NewTargetMuscleGroup = e.TargetMuscleGroup
                })
                .FirstOrDefaultAsync(e => e.Id == id);

            return exercise;
        }

        /// <summary>
        /// Method is used for updating exercise data.
        /// </summary>
        /// <param name="model">Receives class EditExerciseFormModel</param>
        /// <returns>Saves changes in database.</returns>
        public async Task EditExercise(EditExerciseFormModel model)
        {
            var exercise = await _repository.All<Exercise>()
                .FirstAsync(e => e.Id == model.Id);

            exercise.ExerciseName = model.ExerciseNewName;
            exercise.ExerciseDescription = model.ExerciseNewDescription;
            exercise.TargetMuscleGroup = model.NewTargetMuscleGroup;
            exercise.ImageUrl = model.ImageUrl;

            await _repository.SaveAsync();
        }

        /// <summary>
        /// Method is used when creating new exercises.
        /// </summary>
        /// <param name="model">Receives class AddExerciseFormModel</param>
        /// <returns>Adds and saves new entity.</returns>
        public async Task CreateExercise(AddExerciseFormModel model)
        {
            var newExercise = new Exercise()
            {
                ExerciseName = model.ExerciseName,
                ExerciseDescription = model.Description,
                TargetMuscleGroup = model.TargetMuscleGroup,
                ImageUrl = model.ImageUrl
            };

            await _repository.AddAsync(newExercise);
            await _repository.SaveAsync();
        }
    }
}
