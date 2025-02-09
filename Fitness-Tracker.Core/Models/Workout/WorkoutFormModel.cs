using Fitness_Tracker.Core.Models.Intensity;
using System.ComponentModel.DataAnnotations;

namespace Fitness_Tracker.Core.Models.Workout
{
    /// <summary>
    /// Class is used for creating a new Workout.
    /// </summary>
    public class WorkoutFormModel
    {
        public int AthleteId { get; set; }

        public IEnumerable<IntensityFormModel> Intensities { get; set; } = new List<IntensityFormModel>();
    }
}
