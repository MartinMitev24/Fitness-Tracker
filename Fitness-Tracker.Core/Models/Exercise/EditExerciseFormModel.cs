using Fitness_Tracker.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static Fitness_Tracker.Infrastructure.Data.Constants.DataConstants;
using static Fitness_Tracker.Infrastructure.Data.Constants.ErrorMassages;

namespace Fitness_Tracker.Core.Models.Exercise
{
    /// <summary>
    /// Class is used for editing exercsie data.
    /// </summary>
    public class EditExerciseFormModel
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
        /// Exercise new name. Type: string. Length between: 5 and 50 characters.
        /// </summary>
        [Required]
        [StringLength(ExerciseNameMaxLength, MinimumLength = ExerciseNameMinLength, ErrorMessage = StringLengthMessage)]
        public required string ExerciseNewName { get; set; } = string.Empty;

        /// <summary>
        /// Description of the exercise.
        /// </summary>
        public required string ExerciseDescription { get; set; }

        /// <summary>
        /// Exercise new description. Type: string. Length between: 5 and 1000 characters.
        /// </summary>
        [Required]
        [StringLength(ExerciseDescriptionMaxLength, MinimumLength = ExerciseDescriptionMinLength, ErrorMessage = StringLengthMessage)]
        public required string ExerciseNewDescription { get; set; } = string.Empty;

        /// <summary>
        /// Integer value for Exercise targeted muscle group. Can be one of: 0=Stretches, 1=Chest, 2=Back, 3=Shoulder, 4=Biceps, 5=Triceps, 6=Abdominal, 7=Legs, 8=Compound.
        /// </summary>
        public TargetMuscleGroup TargetMuscleGroup { get; set; }

        /// <summary>
        /// Integer value for Exercise changed targeted muscle group. Can be one of: 0=Stretches, 1=Chest, 2=Back, 3=Shoulder, 4=Biceps, 5=Triceps, 6=Abdominal, 7=Legs, 8=Compound. 
        /// </summary>
        public TargetMuscleGroup NewTargetMuscleGroup { get; set; }

        /// <summary>
        /// Example picture for exercise. 
        /// </summary>
        [Url]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
