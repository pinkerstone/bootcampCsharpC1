using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codigo2024Clase34.Migrations
{
    /// <inheritdoc />
    public partial class AgregarEnable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Enable",
                table: "Grades",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Enable",
                table: "Courses",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Enable",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "Enable",
                table: "Courses");
        }
    }
}
