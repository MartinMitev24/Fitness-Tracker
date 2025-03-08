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
        /// Integer value for Exercise Targeted muscle group. Can be one of: 0=Stretches, 1=Chest, 2=Back, 3=Shoulder, 4=Biceps, 5=Triceps, 6=Abdominal, 7=Legs, 8=Compound.
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
