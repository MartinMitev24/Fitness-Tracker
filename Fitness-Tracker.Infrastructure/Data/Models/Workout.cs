using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness_Tracker.Infrastructure.Data.Models
{
    [Comment("Workout table")]
    public class Workout
    {
        [Key]
        [Comment("Workout identifier")]
        public int Id { get; init; }

        [Comment("User Identifier")]
        public int AthleteId { get; set; }

        [Comment("Property for User")]
        public Athlete Athlete { get; set; } = null!;

        [Comment("Property for List of intensities")]
        public IEnumerable<Intensity> Intensities { get; set; } = new List<Intensity>();
    }
}
