using Fitness_Tracker.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

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

        public Intensity SquatIntensity { get; set; }

        public Intensity BicepCurlsIntensity { get; set; }

        public Intensity TricepExetnsionsIntensity { get; set; }

        public Intensity CableRowIntensity { get; set; }

        public Intensity BenchPressIntensity { get; set; }

        public Intensity ShoulderPressIntensity { get; set; }

        public Intensity CrunchesIntensity { get; set; }

        public Workout FirstWorkout { get; set; }

        public IdentityUser Admin { get; set; }

        public IdentityUser TestUserOne { get; set; }

        public SeedData()
        {
            SeedExercises();
            SeedWorkout();
            SeedIntensities();
            SeedUsers();
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

        public void SeedWorkout()
        {
            FirstWorkout = new Workout()
            {
                Id = 1
            };
        }

        public void SeedIntensities()
        {
            SquatIntensity = new Intensity()
            {
                Id = 1,
                LiftedWeight = 50,
                Reps = 10,
                Sets = 3,
                AvarageTimePerSet = 45,
                ExerciseId = Squats.Id,
                WorkoutId = FirstWorkout.Id
            };

            BicepCurlsIntensity = new Intensity()
            {
                Id = 2,
                LiftedWeight = 10,
                Reps = 10,
                Sets = 3,
                AvarageTimePerSet = 45,
                ExerciseId = BicepCurls.Id,
                WorkoutId = FirstWorkout.Id
            };

            TricepExetnsionsIntensity = new Intensity()
            {
                Id = 3,
                LiftedWeight = 10,
                Reps = 10,
                Sets = 3,
                AvarageTimePerSet = 45,
                ExerciseId = TricepExetnsions.Id,
                WorkoutId = FirstWorkout.Id
            };

            CableRowIntensity = new Intensity()
            {
                Id = 4,
                LiftedWeight = 30,
                Reps = 10,
                Sets = 3,
                AvarageTimePerSet = 45,
                ExerciseId = CableRow.Id,
                WorkoutId = FirstWorkout.Id
            };

            BenchPressIntensity = new Intensity()
            {
                Id = 5,
                LiftedWeight = 40,
                Reps = 10,
                Sets = 3,
                AvarageTimePerSet = 45,
                ExerciseId = BenchPress.Id,
                WorkoutId = FirstWorkout.Id
            };

            ShoulderPressIntensity = new Intensity()
            {
                Id = 6,
                LiftedWeight = 20,
                Reps = 10,
                Sets = 3,
                AvarageTimePerSet = 45,
                ExerciseId = ShoulderPress.Id,
                WorkoutId = FirstWorkout.Id
            };

            CrunchesIntensity = new Intensity()
            {
                Id = 7,
                LiftedWeight = 30,
                Reps = 10,
                Sets = 3,
                AvarageTimePerSet = 45,
                ExerciseId = Crunches.Id,
                WorkoutId = FirstWorkout.Id
            };
        }

        public void SeedUsers()
        {
            Admin = new IdentityUser()
            {
                Id = "8d477d39-83ed-4155-81de-a65dd76c2627",
                UserName = "admin@fitnesstracker.com",
                NormalizedUserName = "ADMIN@FITNESSTRACKER.COM",
                Email = "admin@fitnesstracker.com",
                NormalizedEmail = "ADMIN@FITNESSTRACKER.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(
                    new IdentityUser { UserName = "admin@fitnesstracker.com" }, "12345Admin#")
            };

            TestUserOne = new IdentityUser()
            {
                Id = "99612cd5-354c-42b9-966b-779154d8055c",
                UserName = "testOne@fitnesstracker.com",
                NormalizedUserName = "TESTONE@FITNESSTRACKER.COM",
                Email = "testOne@fitnesstracker.com",
                NormalizedEmail = "TESTONE@FITNESSTRACKER.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(
                    new IdentityUser { UserName = "testOne@fitnesstracker.com" }, "12345TestOne#")
            };
        }

    }
}
