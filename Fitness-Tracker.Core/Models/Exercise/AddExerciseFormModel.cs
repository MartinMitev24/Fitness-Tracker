using Fitness_Tracker.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static Fitness_Tracker.Infrastructure.Data.Constants.DataConstants;
using static Fitness_Tracker.Infrastructure.Data.Constants.ErrorMassages;

namespace Fitness_Tracker.Core.Models.Exercise
{
    /// <summary>
    /// Class is used for adding exercises to database.
    /// </summary>
    public class AddExerciseFormModel
    {
        /// <summary>
        /// Exercise Name. Type: string. Length between: 5 and 50 characters long. 
        /// </summary>
        [Required]
        [StringLength(ExerciseNameMaxLength, MinimumLength = ExerciseNameMinLength, ErrorMessage = StringLengthMessage)]
        public string ExerciseName { get; set; } = string.Empty;

        /// <summary>
        /// Exercise Description. Type: string. Lenght between: 5 and 1000 characters long.
        /// </summary>
        [Required]
        [StringLength(ExerciseDescriptionMaxLength, MinimumLength = ExerciseDescriptionMinLength, ErrorMessage = StringLengthMessage)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Exercise Targeted muscle group. Can be one of: Stretches = 0, Chest = 1, Back = 2, Shoulder = 3, Biceps = 4, Triceps = 5, Abdominal = 6, Legs = 7, Compound = 8
        /// </summary>
        [Required]
        public TargetMuscleGroup TargetMuscleGroup { get; set; }

        /// <summary>
        /// Example picture for exercise.
        /// </summary>
        [Url]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
