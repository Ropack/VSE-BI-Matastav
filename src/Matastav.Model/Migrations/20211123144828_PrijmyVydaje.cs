using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Matastav.Model.Migrations
{
    public partial class PrijmyVydaje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rour01_F_polozka");

            migrationBuilder.CreateTable(
                name: "rour01_F_prijem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CastkaPlan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CastkaSkutecnost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CastkaRozdil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZdrojId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_F_prijem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rour01_F_prijem_rour01_D_zdroj_ZdrojId",
                        column: x => x.ZdrojId,
                        principalTable: "rour01_D_zdroj",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rour01_F_vydaj",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CastkaPlan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CastkaSkutecnost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CastkaRozdil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PobockaId = table.Column<int>(type: "int", nullable: true),
                    PolozkaDruhId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_F_vydaj", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rour01_F_vydaj_rour01_D_pobocka_PobockaId",
                        column: x => x.PobockaId,
                        principalTable: "rour01_D_pobocka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_rour01_F_vydaj_rour01_D_polozka_druh_PolozkaDruhId",
                        column: x => x.PolozkaDruhId,
                        principalTable: "rour01_D_polozka_druh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_rour01_F_prijem_ZdrojId",
                table: "rour01_F_prijem",
                column: "ZdrojId");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_F_vydaj_PobockaId",
                table: "rour01_F_vydaj",
                column: "PobockaId");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_F_vydaj_PolozkaDruhId",
                table: "rour01_F_vydaj",
                column: "PolozkaDruhId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rour01_F_prijem");

            migrationBuilder.DropTable(
                name: "rour01_F_vydaj");

            migrationBuilder.CreateTable(
                name: "rour01_F_polozka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CastkaPlan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CastkaRozdil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CastkaSkutecnost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PobockaId = table.Column<int>(type: "int", nullable: true),
                    PolozkaDruhId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_F_polozka", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rour01_F_polozka_rour01_D_pobocka_PobockaId",
                        column: x => x.PobockaId,
                        principalTable: "rour01_D_pobocka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_rour01_F_polozka_rour01_D_polozka_druh_PolozkaDruhId",
                        column: x => x.PolozkaDruhId,
                        principalTable: "rour01_D_polozka_druh",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_rour01_F_polozka_PobockaId",
                table: "rour01_F_polozka",
                column: "PobockaId");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_F_polozka_PolozkaDruhId",
                table: "rour01_F_polozka",
                column: "PolozkaDruhId");
        }
    }
}
