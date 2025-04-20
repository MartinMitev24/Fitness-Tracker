using Fitness_Tracker.Infrastructure.Data.Enums;

namespace Fitness_Tracker.Core.Models.Exercise
{
    /// <summary>
    /// Class is used for viewing exercises.
    /// </summary>
    public class ExerciseViewModel
    {
        /// <summary>
        /// The Identifier of the exercice.
        /// </summary>
        public required int Id { get; set; }

        /// <summary>
        /// Name of the exercise.
        /// </summary>
        public required string ExerciseName { get; set; }

        /// <summary>
        /// Description of the exercise.
        /// </summary>
        public required string ExerciseDescription { get; set; }

        /// <summary>
        /// Integer value for Exercise Targeted muscle group. Can be one of: 0=Stretches, 1=Chest, 2=Back, 3=Shoulder, 4=Biceps, 5=Triceps, 6=Abdominal, 7=Legs, 8=Compound.
        /// </summary>
        public TargetMuscleGroup TargetMuscleGroup { get; set; }

        /// <summary>
        /// Example picture for exercise.
        /// </summary>
        public string ImageUrl { get; set; } = string.Empty;

        /// <summary>
        /// Boolien property for deleting exercises.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
