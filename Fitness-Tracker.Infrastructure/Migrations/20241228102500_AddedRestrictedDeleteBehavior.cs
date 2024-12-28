using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness_Tracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedRestrictedDeleteBehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Athletes_AspNetUsers_UserID",
                table: "Athletes");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Athletes_AthleteId",
                table: "Workouts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d477d39-83ed-4155-81de-a65dd76c2627",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5453f844-8af5-47fc-b911-4522a1ce7ae4", "AQAAAAIAAYagAAAAEDjB53493HTAzIF8PcMVgFjqW9WlghjW54eeK+UXy1mx1wk6F7Ec6v6DCMcdkOfmIA==", "a7f1e4a2-6865-4e27-a514-92f38443cac0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99612cd5-354c-42b9-966b-779154d8055c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf8917d7-b9a6-4ee0-87dc-3c08e4f1a4e9", "AQAAAAIAAYagAAAAEO9xsR4PYEwrY7YeyxRLOplF3RZTOb8EDDJq2M1SERTBjVbaES92RBvJDhgxbgK3EA==", "a0d185d1-ef28-4916-b06e-fca593ef7850" });

            migrationBuilder.AddForeignKey(
                name: "FK_Athletes_AspNetUsers_UserID",
                table: "Athletes",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Athletes_AthleteId",
                table: "Workouts",
                column: "AthleteId",
                principalTable: "Athletes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Athletes_AspNetUsers_UserID",
                table: "Athletes");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Athletes_AthleteId",
                table: "Workouts");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Athletes_AspNetUsers_UserID",
                table: "Athletes",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Athletes_AthleteId",
                table: "Workouts",
                column: "AthleteId",
                principalTable: "Athletes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
