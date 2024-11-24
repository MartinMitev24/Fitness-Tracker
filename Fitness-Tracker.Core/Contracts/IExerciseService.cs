using Fitness_Tracker.Core.Models.Exercise;

namespace Fitness_Tracker.Core.Contracts
{
    public interface IExerciseService
    {
        Task<IEnumerable<ExerciseViewModel>> GetAllAsync();

        Task<ExerciseViewModel> FindExercise(int id);

        Task<EditExerciseFormModel> GetExercise(int id);

        Task EditExercise(EditExerciseFormModel model);

        Task CreateExercise(AddExerciseFormModel model);
    }
}
