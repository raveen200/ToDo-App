using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoServices.API.Migrations
{
    /// <inheritdoc />
    public partial class lk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tile",
                table: "TodoTasks",
                newName: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "TodoTasks",
                newName: "Tile");
        }
    }
}
