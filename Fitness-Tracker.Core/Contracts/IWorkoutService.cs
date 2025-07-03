using Fitness_Tracker.Core.Models.Intensity;
using Fitness_Tracker.Core.Models.Workout;
using Fitness_Tracker.Infrastructure.Data.Models;

namespace Fitness_Tracker.Core.Contracts
{
    public interface IWorkoutService
    {
        Task<IEnumerable<WorkoutViewModel>> GetAllAsync(int athleteId);

        Task<int> GetAthleteId(string userId);

        Task<WorkoutViewModel> FindWorkout(int id);

        Task<Workout> GetWorkout(int id);

        Task<IEnumerable<ExerciseToChooseViewModel>> GetExerciseToChoose();

        Task CreateWorkout(WorkoutFormModel model, int athleteId);

        Task DeleteWorkout(int id);

        Task EditWorkout(int id, List<IntensityFormModel> intensities);
    }
}
