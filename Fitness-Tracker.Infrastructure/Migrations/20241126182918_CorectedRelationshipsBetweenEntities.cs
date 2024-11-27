using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness_Tracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CorectedRelationshipsBetweenEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intensities_Workouts_IntensityId",
                table: "Intensities");

            migrationBuilder.DropIndex(
                name: "IX_Intensities_IntensityId",
                table: "Intensities");

            migrationBuilder.DropColumn(
                name: "IntensityId",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "IntensityId",
                table: "Intensities");

            migrationBuilder.AddColumn<int>(
                name: "LiftedWeight",
                table: "Intensities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "The avarage weight with witch the exercise was performed.");

            migrationBuilder.AddColumn<int>(
                name: "WorkoutId",
                table: "Intensities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Workout identifier");

            migrationBuilder.CreateIndex(
                name: "IX_Intensities_WorkoutId",
                table: "Intensities",
                column: "WorkoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Intensities_Workouts_WorkoutId",
                table: "Intensities",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intensities_Workouts_WorkoutId",
                table: "Intensities");

            migrationBuilder.DropIndex(
                name: "IX_Intensities_WorkoutId",
                table: "Intensities");

            migrationBuilder.DropColumn(
                name: "LiftedWeight",
                table: "Intensities");

            migrationBuilder.DropColumn(
                name: "WorkoutId",
                table: "Intensities");

            migrationBuilder.AddColumn<int>(
                name: "IntensityId",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Intensity identifier");

            migrationBuilder.AddColumn<int>(
                name: "IntensityId",
                table: "Intensities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Intensities_IntensityId",
                table: "Intensities",
                column: "IntensityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Intensities_Workouts_IntensityId",
                table: "Intensities",
                column: "IntensityId",
                principalTable: "Workouts",
                principalColumn: "Id");
        }
    }
}
