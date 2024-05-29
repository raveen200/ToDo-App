using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoServices.API.Migrations
{
    /// <inheritdoc />
    public partial class setdb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Task",
                table: "TodoTasks",
                newName: "Tile");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TodoTasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TodoTasks");

            migrationBuilder.RenameColumn(
                name: "Tile",
                table: "TodoTasks",
                newName: "Task");
        }
    }
}
