using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace net_ef_videogame.Migrations
{
    /// <inheritdoc />
    public partial class Videogame1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "software_house_tax_id",
                table: "software_houses",
                newName: "software_house__tax_id");

            migrationBuilder.RenameIndex(
                name: "IX_software_houses_software_house_tax_id",
                table: "software_houses",
                newName: "IX_software_houses_software_house__tax_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "software_house__tax_id",
                table: "software_houses",
                newName: "software_house_tax_id");

            migrationBuilder.RenameIndex(
                name: "IX_software_houses_software_house__tax_id",
                table: "software_houses",
                newName: "IX_software_houses_software_house_tax_id");
        }
    }
}
