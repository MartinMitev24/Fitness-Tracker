using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
