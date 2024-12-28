using Fitness_Tracker.Core.Models.Workout;

namespace Fitness_Tracker.Core.Contracts
{
    public interface IWorkoutService
    {
        Task<IEnumerable<WorkoutViewModel>> GetAllAsync(int athleteId);

        Task<int> GetAthleteId(string userId);

        Task<WorkoutViewModel> FindWorkout(int id);
    }
}
