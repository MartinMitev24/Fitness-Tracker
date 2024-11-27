using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Fitness_Tracker.Infrastructure.Data.Models
{
    [Comment("Workout")]
    public class Workout
    {
        [Key]
        [Comment("Workout identifier")]
        public int Id { get; init; }

        public IEnumerable<Intensity> Intensities { get; set; } = new List<Intensity>();
    }
}
