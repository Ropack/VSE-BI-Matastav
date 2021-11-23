using Microsoft.EntityFrameworkCore.Migrations;

namespace Matastav.Model.Migrations
{
    public partial class Index : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nazev",
                table: "rour01_D_region",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_rour01_D_region_Nazev",
                table: "rour01_D_region",
                column: "Nazev",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_rour01_D_region_Nazev",
                table: "rour01_D_region");

            migrationBuilder.AlterColumn<string>(
                name: "Nazev",
                table: "rour01_D_region",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
