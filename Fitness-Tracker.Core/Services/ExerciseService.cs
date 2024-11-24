using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models.Exercise;
using Fitness_Tracker.Infrastructure.Data.Common;
using Fitness_Tracker.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Fitness_Tracker.Core.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IRepository _repository;

        public ExerciseService(IRepository repository)
        {
            _repository = repository;
        }

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

        public async Task EditExercise(EditExerciseFormModel model)
        {
            var exercise = await _repository.All<Exercise>()
                .FirstAsync(e => e.Id == model.Id);

            exercise.ExerciseName = model.ExerciseNewName;
            exercise.ExerciseDescription = model.ExerciseNewDescription;
            exercise.TargetMuscleGroup = model.NewTargetMuscleGroup;

            await _repository.SaveAsync();
        }

        public async Task CreateExercise(AddExerciseFormModel model)
        {
            var newExercise = new Exercise()
            {
                ExerciseName = model.ExerciseName,
                ExerciseDescription = model.Description,
                TargetMuscleGroup = model.TargetMuscleGroup
            };

            await _repository.AddAsync(newExercise);
            await _repository.SaveAsync();
        }
    }
}
