using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Matastav.Model.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "rour01_D_kraj",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_D_kraj", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rour01_D_pobocka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_D_pobocka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rour01_D_polozka_druh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_D_polozka_druh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rour01_D_zakaznik_kategorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_D_zakaznik_kategorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rour01_D_zamestnanec_pozice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_D_zamestnanec_pozice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rour01_D_zdroj_kategorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_D_zdroj_kategorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rour01_D_region",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KrajId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_D_region", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rour01_D_region_rour01_D_kraj_KrajId",
                        column: x => x.KrajId,
                        principalTable: "rour01_D_kraj",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rour01_F_polozka",
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

            migrationBuilder.CreateTable(
                name: "rour01_D_zakaznik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZakaznikKategorieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_D_zakaznik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rour01_D_zakaznik_rour01_D_zakaznik_kategorie_ZakaznikKategorieId",
                        column: x => x.ZakaznikKategorieId,
                        principalTable: "rour01_D_zakaznik_kategorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rour01_D_zamestnanec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Jmeno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZamestnanecPoziceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_D_zamestnanec", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rour01_D_zamestnanec_rour01_D_zamestnanec_pozice_ZamestnanecPoziceId",
                        column: x => x.ZamestnanecPoziceId,
                        principalTable: "rour01_D_zamestnanec_pozice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rour01_D_zdroj",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZdrojKategorieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_D_zdroj", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rour01_D_zdroj_rour01_D_zdroj_kategorie_ZdrojKategorieId",
                        column: x => x.ZdrojKategorieId,
                        principalTable: "rour01_D_zdroj_kategorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rour01_F_mzda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Castka = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PobockaId = table.Column<int>(type: "int", nullable: false),
                    ZamestnanecId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_F_mzda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rour01_F_mzda_rour01_D_pobocka_PobockaId",
                        column: x => x.PobockaId,
                        principalTable: "rour01_D_pobocka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rour01_F_mzda_rour01_D_zamestnanec_ZamestnanecId",
                        column: x => x.ZamestnanecId,
                        principalTable: "rour01_D_zamestnanec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rour01_F_kontrakt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Vydaje = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Marze = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DobaTrvaniVeDnech = table.Column<double>(type: "float", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZdrojId = table.Column<int>(type: "int", nullable: false),
                    ZakaznikId = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rour01_F_kontrakt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rour01_F_kontrakt_rour01_D_region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "rour01_D_region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rour01_F_kontrakt_rour01_D_zakaznik_ZakaznikId",
                        column: x => x.ZakaznikId,
                        principalTable: "rour01_D_zakaznik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rour01_F_kontrakt_rour01_D_zdroj_ZdrojId",
                        column: x => x.ZdrojId,
                        principalTable: "rour01_D_zdroj",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_rour01_D_region_KrajId",
                table: "rour01_D_region",
                column: "KrajId");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_D_zakaznik_ZakaznikKategorieId",
                table: "rour01_D_zakaznik",
                column: "ZakaznikKategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_D_zamestnanec_ZamestnanecPoziceId",
                table: "rour01_D_zamestnanec",
                column: "ZamestnanecPoziceId");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_D_zdroj_ZdrojKategorieId",
                table: "rour01_D_zdroj",
                column: "ZdrojKategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_F_kontrakt_RegionId",
                table: "rour01_F_kontrakt",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_F_kontrakt_ZakaznikId",
                table: "rour01_F_kontrakt",
                column: "ZakaznikId");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_F_kontrakt_ZdrojId",
                table: "rour01_F_kontrakt",
                column: "ZdrojId");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_F_mzda_PobockaId",
                table: "rour01_F_mzda",
                column: "PobockaId");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_F_mzda_ZamestnanecId",
                table: "rour01_F_mzda",
                column: "ZamestnanecId");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_F_polozka_PobockaId",
                table: "rour01_F_polozka",
                column: "PobockaId");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_F_polozka_PolozkaDruhId",
                table: "rour01_F_polozka",
                column: "PolozkaDruhId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rour01_F_kontrakt");

            migrationBuilder.DropTable(
                name: "rour01_F_mzda");

            migrationBuilder.DropTable(
                name: "rour01_F_polozka");

            migrationBuilder.DropTable(
                name: "rour01_D_region");

            migrationBuilder.DropTable(
                name: "rour01_D_zakaznik");

            migrationBuilder.DropTable(
                name: "rour01_D_zdroj");

            migrationBuilder.DropTable(
                name: "rour01_D_zamestnanec");

            migrationBuilder.DropTable(
                name: "rour01_D_pobocka");

            migrationBuilder.DropTable(
                name: "rour01_D_polozka_druh");

            migrationBuilder.DropTable(
                name: "rour01_D_kraj");

            migrationBuilder.DropTable(
                name: "rour01_D_zakaznik_kategorie");

            migrationBuilder.DropTable(
                name: "rour01_D_zdroj_kategorie");

            migrationBuilder.DropTable(
                name: "rour01_D_zamestnanec_pozice");
        }
    }
}
