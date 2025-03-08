namespace Fitness_Tracker.Core.Models.Workout
{
    /// <summary>
    /// Class is used for choosing an exercise for IntensityFormModel when creating a new workout.
    /// </summary>
    public class ExerciseToChooseViewModel
    {
        /// <summary>
        /// Exercise Identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Exercise name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Targeted muscle.
        /// </summary>
        public string MuscleType { get; set; } = string.Empty;
    }
}
