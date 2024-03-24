using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotellerie.Migrations
{
    /// <inheritdoc />
    public partial class AjoutPaysHotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "country",
                table: "Hotels",
                newName: "Pays");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pays",
                table: "Hotels",
                newName: "country");
        }
    }
}
