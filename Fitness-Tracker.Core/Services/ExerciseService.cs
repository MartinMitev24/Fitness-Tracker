using Fitness_Tracker.Core.Contracts;
using Fitness_Tracker.Core.Models;
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
    }
}
