using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ToDoServices.API.Migrations
{
    /// <inheritdoc />
    public partial class setdb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoTasks",
                columns: new[] { "Id", "Description", "IsCompleted", "Tile" },
                values: new object[,]
                {
                    { 1, "Description 1", false, "Task 1" },
                    { 2, "Description 2", false, "Task 2" },
                    { 3, "Description 3", false, "Task 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
