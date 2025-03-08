namespace Fitness_Tracker.Core.Models.Intensity
{
    /// <summary>
    /// Class is used to create temporary data for performed exersices in workouts.
    /// </summary>
    public class IntensityFormModel
    {
        /// <summary>
        /// Exercise Identifier.
        /// </summary>
        public int ExerciseId { get; set; }

        /// <summary>
        /// Integer for the used weight.
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Integer for the number of repetitions performed.
        /// </summary>
        public int Reps { get; set; }

        /// <summary>
        /// Integer for the number of sets performed.
        /// </summary>
        public int Sets { get; set; }

        /// <summary>
        /// Integer for the average time of a set.
        /// </summary>
        public int Time { get; set; }
    }
}
