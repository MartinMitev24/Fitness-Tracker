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
                TargetMuscleGroup = Enums.TargetMuscleGroup.Legs,
                ImageUrl = "https://images.unsplash.com/photo-1612957824445-f0c090ff1af0?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8c3F1YXRzfGVufDB8fDB8fHww"
            };
        }
    }
}
