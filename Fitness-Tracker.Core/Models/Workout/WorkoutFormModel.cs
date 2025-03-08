using Fitness_Tracker.Core.Models.Intensity;

namespace Fitness_Tracker.Core.Models.Workout
{
    /// <summary>
    /// Class is used for creating a new Workout.
    /// </summary>
    public class WorkoutFormModel
    {
        /// <summary>
        /// Athlete identifier.
        /// </summary>
        public int AthleteId { get; set; }

        /// <summary>
        /// Athlete workouts.
        /// </summary>
        public IEnumerable<IntensityFormModel> Intensities { get; set; } = new List<IntensityFormModel>();
    }
}
