using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codigo2024Clase34.Migrations
{
    /// <inheritdoc />
    public partial class AgregarEnableStudentEnrollment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Enable",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Enable",
                table: "Enrollments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Enable",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Enable",
                table: "Enrollments");
        }
    }
}
