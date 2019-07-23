using Microsoft.EntityFrameworkCore.Migrations;

namespace Center.Production.Migrations
{
    public partial class ThemTruongSlHangAnh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SLAA",
                table: "AppQuanLyNhuans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SLAB",
                table: "AppQuanLyNhuans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SLAC",
                table: "AppQuanLyNhuans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TongTienNhuanAnh",
                table: "AppQuanLyNhuans",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SLAA",
                table: "AppQuanLyNhuans");

            migrationBuilder.DropColumn(
                name: "SLAB",
                table: "AppQuanLyNhuans");

            migrationBuilder.DropColumn(
                name: "SLAC",
                table: "AppQuanLyNhuans");

            migrationBuilder.DropColumn(
                name: "TongTienNhuanAnh",
                table: "AppQuanLyNhuans");
        }
    }
}
