using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness_Tracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedAthletesDbTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Workouts",
                comment: "Workout table",
                oldComment: "Workout");

            migrationBuilder.AddColumn<int>(
                name: "AthleteId",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "User Identifier");

            migrationBuilder.CreateTable(
                name: "Athletes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Athlete identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Athletes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Athletes_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Athlete table");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d477d39-83ed-4155-81de-a65dd76c2627",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b21a975-97cc-46d0-81de-9bfbe159c6a5", "AQAAAAIAAYagAAAAEEP7U4sw9HSHDuwq1SeIb9RtY2UsTD0lET6ZxUeJbWP5kqwJLVnZZ8A0gaRXRLpi9Q==", "9d09f180-a6f0-4403-9e6f-5c5867294306" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99612cd5-354c-42b9-966b-779154d8055c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f56c954-920c-420c-97b8-95e0e453af98", "AQAAAAIAAYagAAAAEChw2GC8Dti1nkIPUVKLqGxhQ7TKujl3fpMbqI9jV4pkjTGdKx5B5z19O63Y4dhlsw==", "2ab8ef75-f44f-4d51-88f2-6f1b6aaa15dc" });

            migrationBuilder.InsertData(
                table: "Athletes",
                columns: new[] { "Id", "UserID" },
                values: new object[,]
                {
                    { 1, "8d477d39-83ed-4155-81de-a65dd76c2627" },
                    { 2, "99612cd5-354c-42b9-966b-779154d8055c" }
                });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "AthleteId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_AthleteId",
                table: "Workouts",
                column: "AthleteId");

            migrationBuilder.CreateIndex(
                name: "IX_Athletes_UserID",
                table: "Athletes",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Athletes_AthleteId",
                table: "Workouts",
                column: "AthleteId",
                principalTable: "Athletes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Athletes_AthleteId",
                table: "Workouts");

            migrationBuilder.DropTable(
                name: "Athletes");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_AthleteId",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "AthleteId",
                table: "Workouts");

            migrationBuilder.AlterTable(
                name: "Workouts",
                comment: "Workout",
                oldComment: "Workout table");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d477d39-83ed-4155-81de-a65dd76c2627",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2dd25d4-9ea5-4a0c-9ffc-f4dadb7ff5d3", "AQAAAAIAAYagAAAAEJbfKz3NyuqyGQJTHqoIOSc0nauox0Jpd+k7W3JS09JZ19CbgEWMfyV1uWCuUeY6nQ==", "de76a3f5-ba9f-4bf7-af58-3e84c3bda269" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99612cd5-354c-42b9-966b-779154d8055c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "614c91da-c8c9-42ed-8c9d-5808060ac897", "AQAAAAIAAYagAAAAEMeSVgySEANgrsppv7ovyXXETy9Wc+R1DjDXO4t+Y1K8F9NVzQzHzLinESH0yoEbOw==", "9c5b2778-44d3-4af8-9cd7-2d95cb270386" });
        }
    }
}
