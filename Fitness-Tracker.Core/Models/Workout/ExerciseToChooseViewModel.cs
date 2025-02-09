namespace Fitness_Tracker.Core.Models.Workout
{
    /// <summary>
    /// Class is used for choosing an exercise for IntensityFormModel when creating a new workout.
    /// </summary>
    public class ExerciseToChooseViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string MuscleType { get; set; } = string.Empty;
    }
}
