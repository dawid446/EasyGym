using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyGym.Migrations
{
    public partial class initial_dataset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "NameCategory" },
                values: new object[] { 1, "Chest" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "NameCategory" },
                values: new object[] { 2, "Back" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "NameCategory" },
                values: new object[] { 3, "Shoulders" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExercisesID", "CategoryID", "NameExercises" },
                values: new object[] { 1, 1, "Benchpress" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExercisesID", "CategoryID", "NameExercises" },
                values: new object[] { 2, 2, "Dead Lift" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExercisesID", "CategoryID", "NameExercises" },
                values: new object[] { 3, 3, "Benchpress" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExercisesID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExercisesID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExercisesID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: 3);
        }
    }
}
