using Fitness_Tracker.Core.Models.Intensity;

namespace Fitness_Tracker.Core.Models.Workout
{
    /// <summary>
    /// Class is used for viewing athlete workouts.
    /// </summary>
    public class WorkoutViewModel
    {
        /// <summary>
        /// Workout identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Athlete identifier.
        /// </summary>
        public int AthleteId { get; set; }

        /// <summary>
        /// Performed exerciceses with there coresponding data.
        /// </summary>
        public IEnumerable<IntensityViewModel> Intensities { get; set; } = new List<IntensityViewModel>();
    }
}
