using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotellerie.Migrations
{
    /// <inheritdoc />
    public partial class AjoutNote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Note",
                table: "Appreciations",
                type: "int",
                nullable: false,
                defaultValue: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Appreciations");
        }
    }
}
