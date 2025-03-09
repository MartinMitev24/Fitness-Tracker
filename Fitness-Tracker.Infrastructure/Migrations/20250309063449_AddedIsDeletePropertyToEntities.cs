using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitness_Tracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsDeletePropertyToEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Workouts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Boolean property for delete.");

            migrationBuilder.AddColumn<string>(
                name: "WorkoutType",
                table: "Workouts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Workout type.");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Intensities",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Boolean property for delete.");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Exercises",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Boolean property for delete.");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d477d39-83ed-4155-81de-a65dd76c2627",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20efacc3-3ab4-487f-afa5-a094c62bb11a", "AQAAAAIAAYagAAAAEASHF2cfqXMFxe1DzFsoXvJnsMQEh7HdrUXRDkstnlSwuaGWBLsC5Ezr/XUBfgu37A==", "8aeeddf4-9888-4224-8757-b2c43bac9b67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99612cd5-354c-42b9-966b-779154d8055c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9256276d-9f57-459d-a4f5-59cdb4238984", "AQAAAAIAAYagAAAAEN4izp4y58QjxK/oHd5WoyayGbxSI8GQzNmZPFGQyFfaJeG2FhuQoQQZz0hByXKoyg==", "f874522e-9df9-4311-b500-f3076f7a2129" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Intensities",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Intensities",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Intensities",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Intensities",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Intensities",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Intensities",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Intensities",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsDeleted", "WorkoutType" },
                values: new object[] { false, "Full body." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "WorkoutType",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Intensities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Exercises");

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
        }
    }
}
