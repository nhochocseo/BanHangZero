using Microsoft.EntityFrameworkCore.Migrations;

namespace Center.Production.Migrations
{
    public partial class fix_sai_ten_LinkClip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LinlClip",
                table: "AppQuanLyNhuans",
                newName: "LinkClip");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LinkClip",
                table: "AppQuanLyNhuans",
                newName: "LinlClip");
        }
    }
}
