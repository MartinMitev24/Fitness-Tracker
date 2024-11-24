using Fitness_Tracker.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static Fitness_Tracker.Infrastructure.Data.Constants.DataConstants;
using static Fitness_Tracker.Infrastructure.Data.Constants.ErrorMassages;

namespace Fitness_Tracker.Core.Models.Exercise
{
    public class AddExerciseFormModel
    {
        [Required]
        [StringLength(ExerciseNameMaxLength, MinimumLength = ExerciseNameMinLength, ErrorMessage = StringLengthMessage)]
        public string ExerciseName { get; set; } = string.Empty;

        [Required]
        [StringLength(ExerciseDescriptionMaxLength, MinimumLength = ExerciseDescriptionMinLength, ErrorMessage = StringLengthMessage)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public TargetMuscleGroup TargetMuscleGroup { get; set; }

        [Url]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
