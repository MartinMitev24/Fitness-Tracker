using Fitness_Tracker.Infrastructure.Data.Models;

namespace Fitness_Tracker.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public Exercise Squats { get; set; }

        public Exercise BicepCurls { get; set; }

        public Exercise TricepExetnsions { get; set; }

        public Exercise CableRow { get; set; }

        public Exercise BenchPress { get; set; }

        public Exercise ShoulderPress { get; set; }

        public Exercise Crunches { get; set; }

        public Exercise DynamicStretching { get; set; }

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

            BicepCurls = new Exercise()
            {
                Id = 2,
                ExerciseName = "Bicep Curls",
                ExerciseDescription = "Some random text for testing.",
                TargetMuscleGroup = Enums.TargetMuscleGroup.Biceps,
                ImageUrl = string.Empty
            };

            TricepExetnsions = new Exercise()
            {
                Id = 3,
                ExerciseName = "Tricep Extentions",
                ExerciseDescription = "Some random text for testing.",
                TargetMuscleGroup = Enums.TargetMuscleGroup.Triceps,
                ImageUrl = string.Empty
            };

            CableRow = new Exercise()
            {
                Id = 4,
                ExerciseName = "Cable Row",
                ExerciseDescription = "Some random text for testing.",
                TargetMuscleGroup = Enums.TargetMuscleGroup.Back,
                ImageUrl = string.Empty
            };

            BenchPress = new Exercise()
            {
                Id = 5,
                ExerciseName = "Bench Press",
                ExerciseDescription = "Some random text for testing.",
                TargetMuscleGroup = Enums.TargetMuscleGroup.Chest,
                ImageUrl = string.Empty
            };

            ShoulderPress = new Exercise()
            {
                Id = 6,
                ExerciseName = "Shoulder Press",
                ExerciseDescription = "Some random text for testing.",
                TargetMuscleGroup = Enums.TargetMuscleGroup.Shoulder,
                ImageUrl = string.Empty
            };

            Crunches = new Exercise()
            {
                Id = 7,
                ExerciseName = "Crunches",
                ExerciseDescription = "Some random text for testing.",
                TargetMuscleGroup = Enums.TargetMuscleGroup.Chest,
                ImageUrl = string.Empty
            };

            DynamicStretching = new Exercise()
            {
                Id = 8,
                ExerciseName = "Dynamic stretching",
                ExerciseDescription = "Some random text for testing.",
                TargetMuscleGroup = Enums.TargetMuscleGroup.Stretches,
                ImageUrl = string.Empty
            };
        }
    }
}
