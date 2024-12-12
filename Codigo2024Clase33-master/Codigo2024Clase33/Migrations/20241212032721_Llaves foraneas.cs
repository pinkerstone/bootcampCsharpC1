using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Codigo2024Clase33.Migrations
{
    /// <inheritdoc />
    public partial class Llavesforaneas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendedorID",
                table: "Facturas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FacturaID",
                table: "Detalles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    VendedorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.VendedorID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_VendedorID",
                table: "Facturas",
                column: "VendedorID");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_FacturaID",
                table: "Detalles",
                column: "FacturaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_Facturas_FacturaID",
                table: "Detalles",
                column: "FacturaID",
                principalTable: "Facturas",
                principalColumn: "FacturaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Vendedor_VendedorID",
                table: "Facturas",
                column: "VendedorID",
                principalTable: "Vendedor",
                principalColumn: "VendedorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_Facturas_FacturaID",
                table: "Detalles");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Vendedor_VendedorID",
                table: "Facturas");

            migrationBuilder.DropTable(
                name: "Vendedor");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_VendedorID",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Detalles_FacturaID",
                table: "Detalles");

            migrationBuilder.DropColumn(
                name: "VendedorID",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "FacturaID",
                table: "Detalles");
        }
    }
}
