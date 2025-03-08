using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fitness_Tracker.Core.Models.Intensity
{
    /// <summary>
    /// Class is used for viewing performed exersices data in workouts.
    /// </summary>
    public class IntensityViewModel
    {
        /// <summary>
        /// Intensity Identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Performed Exercise name.
        /// </summary>
        public string ExerciseName { get; set; } = string.Empty;

        /// <summary>
        /// Integer for the weight used in the exercise.
        /// </summary>
        public int LiftedWeight { get; set; }

        /// <summary>
        /// Integer for the number repetitions performed for the exercise.
        /// </summary>
        public int Reps { get; set; }

        /// <summary>
        /// Integer for the number of performed sets. 
        /// </summary>
        public int Sets { get; set; }

        /// <summary>
        /// Integer for the avarage time spent on one set.
        /// </summary>
        public int AvarageTimePerSet { get; set; }

        /// <summary>
        /// Workout Identifier associated with the performed exercise.
        /// </summary>
        public int WorkoutId { get; set; }
    }
}
