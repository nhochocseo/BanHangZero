using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Center.Production.Migrations
{
    public partial class ThemBangTintuc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TinTucs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TieuDe = table.Column<string>(maxLength: 250, nullable: true),
                    NoiDung = table.Column<string>(maxLength: 5000, nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    DanhMucId = table.Column<int>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false),
                    NgayThem = table.Column<string>(nullable: true),
                    NgaySua = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinTucs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TinTucs");
        }
    }
}
