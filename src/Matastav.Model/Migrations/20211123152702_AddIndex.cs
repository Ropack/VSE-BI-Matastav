using Microsoft.EntityFrameworkCore.Migrations;

namespace Matastav.Model.Migrations
{
    public partial class AddIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nazev",
                table: "rour01_D_vydaj_druh",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_D_vydaj_druh_Nazev",
                table: "rour01_D_vydaj_druh",
                column: "Nazev",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_rour01_D_vydaj_druh_Nazev",
                table: "rour01_D_vydaj_druh");

            migrationBuilder.AlterColumn<string>(
                name: "Nazev",
                table: "rour01_D_vydaj_druh",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
