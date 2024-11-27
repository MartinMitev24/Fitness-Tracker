using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness_Tracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CorectetTableNameForIntensities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_intensities_Exercises_ExerciseId",
                table: "intensities");

            migrationBuilder.DropForeignKey(
                name: "FK_intensities_Workouts_IntensityId",
                table: "intensities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_intensities",
                table: "intensities");

            migrationBuilder.RenameTable(
                name: "intensities",
                newName: "Intensities");

            migrationBuilder.RenameIndex(
                name: "IX_intensities_IntensityId",
                table: "Intensities",
                newName: "IX_Intensities_IntensityId");

            migrationBuilder.RenameIndex(
                name: "IX_intensities_ExerciseId",
                table: "Intensities",
                newName: "IX_Intensities_ExerciseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Intensities",
                table: "Intensities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Intensities_Exercises_ExerciseId",
                table: "Intensities",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Intensities_Workouts_IntensityId",
                table: "Intensities",
                column: "IntensityId",
                principalTable: "Workouts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intensities_Exercises_ExerciseId",
                table: "Intensities");

            migrationBuilder.DropForeignKey(
                name: "FK_Intensities_Workouts_IntensityId",
                table: "Intensities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Intensities",
                table: "Intensities");

            migrationBuilder.RenameTable(
                name: "Intensities",
                newName: "intensities");

            migrationBuilder.RenameIndex(
                name: "IX_Intensities_IntensityId",
                table: "intensities",
                newName: "IX_intensities_IntensityId");

            migrationBuilder.RenameIndex(
                name: "IX_Intensities_ExerciseId",
                table: "intensities",
                newName: "IX_intensities_ExerciseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_intensities",
                table: "intensities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_intensities_Exercises_ExerciseId",
                table: "intensities",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_intensities_Workouts_IntensityId",
                table: "intensities",
                column: "IntensityId",
                principalTable: "Workouts",
                principalColumn: "Id");
        }
    }
}
