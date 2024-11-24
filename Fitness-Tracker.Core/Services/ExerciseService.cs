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
                    TargetMuscleGroup = e.TargetMuscleGroup
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
                    TargetMuscleGroup = e.TargetMuscleGroup
                })
                .FirstOrDefaultAsync(e => e.Id == id);

            return exercise;
        }

        public async Task<ExerciseFormModel> GetExercise(int id)
        {
            var exercise = await _repository.AllReadOnly<Exercise>()
                .Select(e => new ExerciseFormModel
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

        public async Task EditExercise(ExerciseFormModel model)
        {
            var exercise = await _repository.All<Exercise>()
                .FirstAsync(e => e.Id == model.Id);

            exercise.ExerciseName = model.ExerciseNewName;
            exercise.ExerciseDescription = model.ExerciseNewDescription;
            exercise.TargetMuscleGroup = model.NewTargetMuscleGroup;

            await _repository.SaveAsync();
        }
    }
}
