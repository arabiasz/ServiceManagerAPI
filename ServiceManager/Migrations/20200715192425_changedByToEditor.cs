using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceManager.Migrations
{
    public partial class changedByToEditor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChangedBy",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "ChangedBy",
                table: "Category");

            migrationBuilder.AddColumn<string>(
                name: "Editor",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Editor",
                table: "Category",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Editor",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Editor",
                table: "Category");

            migrationBuilder.AddColumn<string>(
                name: "ChangedBy",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChangedBy",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
