using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness_Tracker.Infrastructure.Data.Models
{
    [Comment("Exercise intensity for current workout.")]
    public class Intensity
    {
        [Key]
        [Comment("Intensity identifier.")]
        public int Id { get; init; }
        
        [Required]
        [Comment("Number of repetitions the exercise was performed.")]
        public int Reps { get; set; }

        [Required]
        [Comment("Number of sets performed.")]
        public int Sets { get; set; }

        [Required]
        [Comment("Avarage Number of seconds per one set.")]
        public int AvarageTimePerSet { get; set; }

        [Required]
        [Comment("Identifier of current exercise.")]
        public int ExerciseId { get; set; }

        [ForeignKey(nameof(ExerciseId))]
        [Comment("Current exercise")]
        public required Exercise Exercise { get; set; }
    }
}
