using Fitness_Tracker.Core.Models.Workout;

namespace Fitness_Tracker.Core.Contracts
{
    public interface IWorkoutService
    {
        Task<IEnumerable<WorkoutViewModel>> GetAllAsync();

        Task<WorkoutViewModel> FindWorkout(int id);

        //Task<EditExerciseFormModel> GetExercise(int id);

        //Task EditExercise(EditExerciseFormModel model);

        //Task CreateExercise(AddExerciseFormModel model);
    }
}
