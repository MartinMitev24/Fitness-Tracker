using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace Fitness_Tracker.Infrastructure.Data.Models
{
    [Comment("Exercise intensity for current workout.")]
    public class Intensity
    {
        [Key]
        [Comment("Intensity identifier.")]
        public int Id { get; init; }

        [Required]
        [Comment("The avarage weight with witch the exercise was performed.")]
        public int LiftedWeight { get; set; }

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
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [Comment("Current exercise")]
        public Exercise Exercise { get; set; } = null!;

        [Required]
        [Comment("Workout identifier")]
        public int WorkoutId { get; set; }

        [ForeignKey(nameof(WorkoutId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [Comment("Current workout")]
        public Workout Workout { get; set; } = null!;

    }
}
