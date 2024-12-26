using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitness_Tracker.Infrastructure.Data.Models
{
    [Comment("Athlete table")]
    public class Athlete
    {
        [Comment("Athlete identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("User Identifier")]
        public string UserID { get; set; }

        [Comment("Property For User")]
        [ForeignKey(nameof(UserID))]
        public IdentityUser User { get; set; } = null!;

        [Comment("Property for List of workouts")]
        public IEnumerable<Workout> Workouts { get; set; } = new List<Workout>();
    }
}
