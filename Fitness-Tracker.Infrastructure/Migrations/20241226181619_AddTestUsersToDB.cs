using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness_Tracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddTestUsersToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8d477d39-83ed-4155-81de-a65dd76c2627", 0, "a2dd25d4-9ea5-4a0c-9ffc-f4dadb7ff5d3", "admin@fitnesstracker.com", true, false, null, "ADMIN@FITNESSTRACKER.COM", "ADMIN@FITNESSTRACKER.COM", "AQAAAAIAAYagAAAAEJbfKz3NyuqyGQJTHqoIOSc0nauox0Jpd+k7W3JS09JZ19CbgEWMfyV1uWCuUeY6nQ==", null, false, "de76a3f5-ba9f-4bf7-af58-3e84c3bda269", false, "admin@fitnesstracker.com" },
                    { "99612cd5-354c-42b9-966b-779154d8055c", 0, "614c91da-c8c9-42ed-8c9d-5808060ac897", "testOne@fitnesstracker.com", true, false, null, "TESTONE@FITNESSTRACKER.COM", "TESTONE@FITNESSTRACKER.COM", "AQAAAAIAAYagAAAAEMeSVgySEANgrsppv7ovyXXETy9Wc+R1DjDXO4t+Y1K8F9NVzQzHzLinESH0yoEbOw==", null, false, "9c5b2778-44d3-4af8-9cd7-2d95cb270386", false, "testOne@fitnesstracker.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d477d39-83ed-4155-81de-a65dd76c2627");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99612cd5-354c-42b9-966b-779154d8055c");
        }
    }
}
