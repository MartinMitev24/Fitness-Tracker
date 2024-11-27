using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness_Tracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DomainTablesSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intensities_Exercises_ExerciseId",
                table: "Intensities");

            migrationBuilder.DropForeignKey(
                name: "FK_Intensities_Workouts_WorkoutId",
                table: "Intensities");

            migrationBuilder.InsertData(
                table: "Workouts",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "Intensities",
                columns: new[] { "Id", "AvarageTimePerSet", "ExerciseId", "LiftedWeight", "Reps", "Sets", "WorkoutId" },
                values: new object[,]
                {
                    { 1, 45, 1, 50, 10, 3, 1 },
                    { 2, 45, 2, 10, 10, 3, 1 },
                    { 3, 45, 3, 10, 10, 3, 1 },
                    { 4, 45, 4, 30, 10, 3, 1 },
                    { 5, 45, 5, 40, 10, 3, 1 },
                    { 6, 45, 6, 20, 10, 3, 1 },
                    { 7, 45, 7, 30, 10, 3, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Intensities_Exercises_ExerciseId",
                table: "Intensities",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Intensities_Workouts_WorkoutId",
                table: "Intensities",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intensities_Exercises_ExerciseId",
                table: "Intensities");

            migrationBuilder.DropForeignKey(
                name: "FK_Intensities_Workouts_WorkoutId",
                table: "Intensities");

            migrationBuilder.DeleteData(
                table: "Intensities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Intensities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Intensities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Intensities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Intensities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Intensities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Intensities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Intensities_Exercises_ExerciseId",
                table: "Intensities",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Intensities_Workouts_WorkoutId",
                table: "Intensities",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
