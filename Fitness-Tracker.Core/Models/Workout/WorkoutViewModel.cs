using Fitness_Tracker.Core.Models.Intensity;

namespace Fitness_Tracker.Core.Models.Workout
{
    public class WorkoutViewModel
    {
        public int Id { get; set; }

        public int AthleteId { get; set; }

        public IEnumerable<IntensityViewModel> Intensities { get; set; } = new List<IntensityViewModel>();
    }
}
