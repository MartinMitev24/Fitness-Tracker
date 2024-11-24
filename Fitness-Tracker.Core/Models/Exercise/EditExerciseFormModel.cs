using Fitness_Tracker.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static Fitness_Tracker.Infrastructure.Data.Constants.DataConstants;
using static Fitness_Tracker.Infrastructure.Data.Constants.ErrorMassages;

namespace Fitness_Tracker.Core.Models.Exercise
{
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

        [Required]
        [StringLength(ExerciseNameMaxLength, MinimumLength = ExerciseNameMinLength, ErrorMessage = StringLengthMessage)]
        public required string ExerciseNewName { get; set; } = string.Empty;

        /// <summary>
        /// Description of the exercise.
        /// </summary>
        public required string ExerciseDescription { get; set; }

        [Required]
        [StringLength(ExerciseDescriptionMaxLength, MinimumLength = ExerciseDescriptionMinLength, ErrorMessage = StringLengthMessage)]
        public required string ExerciseNewDescription { get; set; } = string.Empty;

        /// <summary>
        /// Integer value for muscle groupe of the exercice. 0=None, 1=Chest, 2=Back, 3=Shoulder, 4=Biceps, 5=Triceps, 6=Abdominal, 7=Legs and8=Compound
        /// </summary>
        public TargetMuscleGroup TargetMuscleGroup { get; set; }

        public TargetMuscleGroup NewTargetMuscleGroup { get; set; }

        [Url]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
