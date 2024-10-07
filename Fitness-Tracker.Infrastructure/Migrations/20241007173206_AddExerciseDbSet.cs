using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness_Tracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddExerciseDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Exercise identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Exercise name, can be of maximum 50 characters"),
                    ExerciseDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Exercise description, can be of maximum 1000 characters"),
                    TargetMuscleGroup = table.Column<int>(type: "int", nullable: false, comment: "Exercise muscle group")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                },
                comment: "Exercise");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");
        }
    }
}
