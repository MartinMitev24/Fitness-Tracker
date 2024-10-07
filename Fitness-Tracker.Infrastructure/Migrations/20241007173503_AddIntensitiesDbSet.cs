using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness_Tracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIntensitiesDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "intensities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Intensity identifier.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reps = table.Column<int>(type: "int", nullable: false, comment: "Number of repetitions the exercise was performed."),
                    Sets = table.Column<int>(type: "int", nullable: false, comment: "Number of sets performed."),
                    AvarageTimePerSet = table.Column<int>(type: "int", nullable: false, comment: "Avarage Number of seconds per one set."),
                    ExerciseId = table.Column<int>(type: "int", nullable: false, comment: "Identifier of current exercise.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_intensities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_intensities_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Exercise intensity for current workout.");

            migrationBuilder.CreateIndex(
                name: "IX_intensities_ExerciseId",
                table: "intensities",
                column: "ExerciseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "intensities");
        }
    }
}
