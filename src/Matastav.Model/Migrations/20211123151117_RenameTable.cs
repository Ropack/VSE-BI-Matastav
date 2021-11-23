using Microsoft.EntityFrameworkCore.Migrations;

namespace Matastav.Model.Migrations
{
    public partial class RenameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rour01_F_vydaj_rour01_D_polozka_druh_PolozkaDruhId",
                table: "rour01_F_vydaj");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rour01_D_polozka_druh",
                table: "rour01_D_polozka_druh");

            migrationBuilder.RenameTable(
                name: "rour01_D_polozka_druh",
                newName: "rour01_D_vydaj_druh");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rour01_D_vydaj_druh",
                table: "rour01_D_vydaj_druh",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_rour01_F_vydaj_rour01_D_vydaj_druh_PolozkaDruhId",
                table: "rour01_F_vydaj",
                column: "PolozkaDruhId",
                principalTable: "rour01_D_vydaj_druh",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rour01_F_vydaj_rour01_D_vydaj_druh_PolozkaDruhId",
                table: "rour01_F_vydaj");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rour01_D_vydaj_druh",
                table: "rour01_D_vydaj_druh");

            migrationBuilder.RenameTable(
                name: "rour01_D_vydaj_druh",
                newName: "rour01_D_polozka_druh");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rour01_D_polozka_druh",
                table: "rour01_D_polozka_druh",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_rour01_F_vydaj_rour01_D_polozka_druh_PolozkaDruhId",
                table: "rour01_F_vydaj",
                column: "PolozkaDruhId",
                principalTable: "rour01_D_polozka_druh",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
