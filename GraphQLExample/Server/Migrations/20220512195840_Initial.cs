using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLExample.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lotussen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lotussen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Opdrachten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DatumAanvraag = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BeginTijd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AantalUur = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opdrachten", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lotussen");

            migrationBuilder.DropTable(
                name: "Opdrachten");
        }
    }
}
