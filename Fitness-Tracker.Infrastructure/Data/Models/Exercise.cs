using Fitness_Tracker.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Fitness_Tracker.Infrastructure.Data.Constants.DataConstants;

namespace Fitness_Tracker.Infrastructure.Data.Models
{
    [Comment("Exercise")]
    public class Exercise
    {
        [Key]
        [Comment("Exercise identifier")]
        public int Id { get; init; }

        [Required]
        [MaxLength(ExerciseNameMaxLength)]
        [Comment("Exercise name, can be of maximum 50 characters")]
        public required string ExerciseName { get; set; }

        [Required]
        [MaxLength(ExerciseDescriptionMaxLength)]
        [Comment("Exercise description, can be of maximum 1000 characters")]

        public required string ExerciseDescription { get; set; }

        [Required]
        [Comment("Exercise muscle group")]
        public TargetMuscleGroup TargetMuscleGroup { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public IEnumerable<Intensity> Intensities { get; set; } = new List<Intensity>();
    }
}
