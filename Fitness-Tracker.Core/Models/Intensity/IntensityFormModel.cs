namespace Fitness_Tracker.Core.Models.Intensity
{
    /// <summary>
    /// Class is used to create temporary data for performed exersices in workouts.
    /// </summary>
    public class IntensityFormModel
    {
        public int ExerciseId { get; set; }

        public int Weight { get; set; }

        public int Reps { get; set; }

        public int Sets { get; set; }

        public int Time { get; set; }
    }
}
