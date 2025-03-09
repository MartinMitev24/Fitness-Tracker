using Fitness_Tracker.Core.Models.Intensity;
using System.ComponentModel.DataAnnotations;
using static Fitness_Tracker.Infrastructure.Data.Constants.DataConstants;
using static Fitness_Tracker.Infrastructure.Data.Constants.ErrorMassages;

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
        /// Property for WorkoutType.
        /// </summary>
        [StringLength(WorkoutTypeMaxLength, MinimumLength = WorkoutTypeMinLength, ErrorMessage = StringLengthMessage)]
        public string WorkoutType { get; set; } = string.Empty;

        /// <summary>
        /// Athlete workouts.
        /// </summary>
        public IEnumerable<IntensityFormModel> Intensities { get; set; } = new List<IntensityFormModel>();
    }
}
