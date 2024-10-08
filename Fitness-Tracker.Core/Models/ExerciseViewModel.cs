using Fitness_Tracker.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static Fitness_Tracker.Infrastructure.Data.Constants.DataConstants;

namespace Fitness_Tracker.Core.Models
{
    public class ExerciseViewModel
    {
        /// <summary>
        /// The Identifier of the exercice.
        /// </summary>
        public required int Id { get; set; }

        /// <summary>
        /// Name of the exercise.
        /// </summary>
        [Required]
        [StringLength(ExerciseNameMaxLength, MinimumLength = ExerciseNameMinLength)]
        public required string ExerciseName { get; set; }

        /// <summary>
        /// Description of the exercise.
        /// </summary>
        [Required]
        [StringLength(ExerciseDescriptionMaxLength, MinimumLength = ExerciseDescriptionMinLength)]
        public required string ExerciseDescription { get; set; }

        /// <summary>
        /// Integer value for muscle groupe of the exercice. 0=None, 1=Chest, 2=Back, 3=Shoulder, 4=Biceps, 5=Triceps, 6=Abdominal, 7=Legs and8=Compound
        /// </summary>
        [Required]
        public TargetMuscleGroup TargetMuscleGroup { get; set; }
    }
}
