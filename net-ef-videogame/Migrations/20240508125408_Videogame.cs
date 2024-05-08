using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace net_ef_videogame.Migrations
{
    /// <inheritdoc />
    public partial class Videogame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "videogame",
                columns: table => new
                {
                    VideogameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    videogame_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    videogame_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    videogame_release = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videogame", x => x.VideogameID);
                });

            migrationBuilder.CreateTable(
                name: "software_houses",
                columns: table => new
                {
                    HouseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    videogame_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    videogame_tax_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    videogame_city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    videogame_country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VideogameID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_software_houses", x => x.HouseID);
                    table.ForeignKey(
                        name: "FK_software_houses_videogame_VideogameID",
                        column: x => x.VideogameID,
                        principalTable: "videogame",
                        principalColumn: "VideogameID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_software_houses_videogame_tax_id",
                table: "software_houses",
                column: "videogame_tax_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_software_houses_VideogameID",
                table: "software_houses",
                column: "VideogameID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "software_houses");

            migrationBuilder.DropTable(
                name: "videogame");
        }
    }
}
