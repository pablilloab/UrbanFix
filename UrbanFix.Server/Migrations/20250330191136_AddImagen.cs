using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrbanFix.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddImagen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Imagenes",
                newName: "Ruta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ruta",
                table: "Imagenes",
                newName: "Url");
        }
    }
}
