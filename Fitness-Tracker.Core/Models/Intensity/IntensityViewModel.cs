using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fitness_Tracker.Core.Models.Intensity
{
    public class IntensityViewModel
    {
        public int Id { get; set; }

        public string ExerciseName { get; set; } = string.Empty;

        public int LiftedWeight { get; set; }

        public int Reps { get; set; }

        public int Sets { get; set; }

        public int AvarageTimePerSet { get; set; }

        public int WorkoutId { get; set; }
    }
}
