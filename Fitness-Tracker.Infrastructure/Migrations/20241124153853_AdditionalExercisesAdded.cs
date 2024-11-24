using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness_Tracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalExercisesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "ExerciseDescription", "ExerciseName", "ImageUrl", "TargetMuscleGroup" },
                values: new object[,]
                {
                    { 2, "Some random text for testing.", "Bicep Curls", "", 4 },
                    { 3, "Some random text for testing.", "Tricep Extentions", "", 5 },
                    { 4, "Some random text for testing.", "Cable Row", "", 2 },
                    { 5, "Some random text for testing.", "Bench Press", "", 1 },
                    { 6, "Some random text for testing.", "Shoulder Press", "", 3 },
                    { 7, "Some random text for testing.", "Crunches", "", 1 },
                    { 8, "Some random text for testing.", "Dynamic stretching", "", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
