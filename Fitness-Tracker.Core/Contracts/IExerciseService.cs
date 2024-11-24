using Fitness_Tracker.Core.Models.Exercise;

namespace Fitness_Tracker.Core.Contracts
{
    public interface IExerciseService
    {
        Task<IEnumerable<ExerciseViewModel>> GetAllAsync();

        Task<ExerciseViewModel> FindExercise(int id);

        Task<ExerciseFormModel> GetExercise(int id);

        Task EditExercise(ExerciseFormModel model);
    }
}
