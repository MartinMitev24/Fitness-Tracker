using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness_Tracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkoutsDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IntensityId",
                table: "intensities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Workout identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntensityId = table.Column<int>(type: "int", nullable: false, comment: "Intensity identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                },
                comment: "Workout");

            migrationBuilder.CreateIndex(
                name: "IX_intensities_IntensityId",
                table: "intensities",
                column: "IntensityId");

            migrationBuilder.AddForeignKey(
                name: "FK_intensities_Workouts_IntensityId",
                table: "intensities",
                column: "IntensityId",
                principalTable: "Workouts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_intensities_Workouts_IntensityId",
                table: "intensities");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_intensities_IntensityId",
                table: "intensities");

            migrationBuilder.DropColumn(
                name: "IntensityId",
                table: "intensities");
        }
    }
}
