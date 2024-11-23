using Fitness_Tracker.Infrastructure.Data.Models;

namespace Fitness_Tracker.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public Exercise Squats { get; set; }

        public SeedData()
        {
            SeedExercises();
        }

        public void SeedExercises()
        {
            Squats = new Exercise()
            {
                Id = 1,
                ExerciseName = "Squats",
                ExerciseDescription = "Some random text for testing.",
                TargetMuscleGroup = Enums.TargetMuscleGroup.Legs
            };
        }
    }
}
