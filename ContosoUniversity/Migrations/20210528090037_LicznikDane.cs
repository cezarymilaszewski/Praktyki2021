using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class LicznikDane : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LicznikDane",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicznikId = table.Column<int>(type: "int", nullable: false),
                    Stan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Zuzycie = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IloscDni = table.Column<int>(type: "int", nullable: false),
                    AvgZuzycie = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataWpisu = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicznikDane", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LicznikDane");
        }
    }
}
