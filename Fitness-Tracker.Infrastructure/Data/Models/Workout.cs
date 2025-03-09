using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Fitness_Tracker.Infrastructure.Data.Constants.DataConstants;

namespace Fitness_Tracker.Infrastructure.Data.Models
{
    [Comment("Workout table")]
    public class Workout
    {
        [Key]
        [Comment("Workout identifier")]
        public int Id { get; init; }

        [Comment("Workout type.")]
        [MaxLength(WorkoutTypeMaxLength)]
        public string WorkoutType { get; set; } = string.Empty;

        [Comment("Boolean property for delete.")]
        public bool IsDeleted { get; set; } = false;

        [Comment("User Identifier")]
        public int AthleteId { get; set; }

        [Comment("Property for User")]
        [ForeignKey(nameof(AthleteId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Athlete Athlete { get; set; } = null!;

        [Comment("Property for List of intensities")]
        public IEnumerable<Intensity> Intensities { get; set; } = new List<Intensity>();
    }
}
