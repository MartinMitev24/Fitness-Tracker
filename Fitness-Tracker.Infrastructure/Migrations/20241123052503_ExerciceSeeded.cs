using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness_Tracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ExerciceSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "ExerciseDescription", "ExerciseName", "TargetMuscleGroup" },
                values: new object[] { 1, "Some random text for testing.", "Squats", 7 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
