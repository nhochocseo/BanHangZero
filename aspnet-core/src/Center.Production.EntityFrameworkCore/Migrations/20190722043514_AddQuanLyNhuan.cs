using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Center.Production.Migrations
{
    public partial class AddQuanLyNhuan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppQuanLyNhuans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaTin = table.Column<string>(maxLength: 100, nullable: true),
                    NgayLenBai = table.Column<DateTime>(nullable: false),
                    MaNhanSu = table.Column<string>(maxLength: 10, nullable: true),
                    TenNhanSu = table.Column<string>(maxLength: 100, nullable: true),
                    ChuyenMuc = table.Column<string>(maxLength: 100, nullable: true),
                    ViTri = table.Column<string>(maxLength: 100, nullable: true),
                    ButDanh = table.Column<string>(maxLength: 50, nullable: true),
                    TenBaiViet = table.Column<string>(maxLength: 500, nullable: true),
                    LoaiBaiViet = table.Column<string>(maxLength: 50, nullable: true),
                    TrangThai = table.Column<byte>(nullable: false),
                    TyLe = table.Column<decimal>(nullable: false),
                    AppHangBaiVietREF = table.Column<int>(nullable: false),
                    TongSoLuongAnh = table.Column<int>(nullable: false),
                    TongSoLuongClip = table.Column<int>(nullable: false),
                    SLClipA = table.Column<int>(nullable: false),
                    SLClipB = table.Column<int>(nullable: false),
                    SLClipC = table.Column<int>(nullable: false),
                    SLClipSanXuat = table.Column<int>(nullable: false),
                    NhuanBaiViet = table.Column<int>(nullable: false),
                    HeSo = table.Column<decimal>(nullable: false),
                    Thuong = table.Column<decimal>(nullable: false),
                    Phat = table.Column<decimal>(nullable: false),
                    TongNhuan = table.Column<decimal>(nullable: false),
                    LinkBai = table.Column<string>(maxLength: 1000, nullable: true),
                    LinlClip = table.Column<string>(maxLength: 1000, nullable: true),
                    TongView = table.Column<int>(nullable: false),
                    ViewWeb = table.Column<int>(nullable: false),
                    ViewMobile = table.Column<int>(nullable: false),
                    TongLike = table.Column<int>(nullable: false),
                    TongShare = table.Column<int>(nullable: false),
                    GhiChu = table.Column<string>(maxLength: 5000, nullable: true),
                    TrangThaiXyLy = table.Column<byte>(nullable: false),
                    NguoiCapNhat = table.Column<string>(maxLength: 50, nullable: true),
                    LyDoNangHang = table.Column<string>(maxLength: 5000, nullable: true),
                    LyDoThuongPhat = table.Column<string>(maxLength: 5000, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<string>(maxLength: 50, nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: false),
                    LastModifierUserId = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<string>(maxLength: 50, nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppQuanLyNhuans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppQuanLyNhuans");
        }
    }
}
