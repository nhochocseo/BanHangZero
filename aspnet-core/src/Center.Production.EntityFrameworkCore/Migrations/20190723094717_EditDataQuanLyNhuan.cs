using Microsoft.EntityFrameworkCore.Migrations;

namespace Center.Production.Migrations
{
    public partial class EditDataQuanLyNhuan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ButDanh",
                table: "AppQuanLyNhuans");

            migrationBuilder.DropColumn(
                name: "LoaiBaiViet",
                table: "AppQuanLyNhuans");

            migrationBuilder.DropColumn(
                name: "MaNhanSu",
                table: "AppQuanLyNhuans");

            migrationBuilder.DropColumn(
                name: "TenNhanSu",
                table: "AppQuanLyNhuans");

            migrationBuilder.RenameColumn(
                name: "AppHangBaiVietREF",
                table: "AppQuanLyNhuans",
                newName: "AppNhanSuRef");

            migrationBuilder.AddColumn<string>(
                name: "AppButDanhRef",
                table: "AppQuanLyNhuans",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppHangREF",
                table: "AppQuanLyNhuans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AppLoaiBaiRef",
                table: "AppQuanLyNhuans",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppButDanhRef",
                table: "AppQuanLyNhuans");

            migrationBuilder.DropColumn(
                name: "AppHangREF",
                table: "AppQuanLyNhuans");

            migrationBuilder.DropColumn(
                name: "AppLoaiBaiRef",
                table: "AppQuanLyNhuans");

            migrationBuilder.RenameColumn(
                name: "AppNhanSuRef",
                table: "AppQuanLyNhuans",
                newName: "AppHangBaiVietREF");

            migrationBuilder.AddColumn<string>(
                name: "ButDanh",
                table: "AppQuanLyNhuans",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoaiBaiViet",
                table: "AppQuanLyNhuans",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaNhanSu",
                table: "AppQuanLyNhuans",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenNhanSu",
                table: "AppQuanLyNhuans",
                maxLength: 100,
                nullable: true);
        }
    }
}
