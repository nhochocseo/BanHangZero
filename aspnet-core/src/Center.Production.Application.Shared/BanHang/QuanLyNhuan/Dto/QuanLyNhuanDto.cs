using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Center.Production.BanHang.QuanLyNhuan.Dto
{
    public class AppQuanLyNhuanDto : EntityDto<long>
    {
        [MaxLength(100)]
        public string MaTin { get; set; }

        public DateTime NgayLenBai { get; set; }

        [MaxLength(10)]
        public string MaNhanSu { get; set; }

        [MaxLength(100)]
        public string TenNhanSu { get; set; }

        [MaxLength(100)]
        public string ChuyenMuc { get; set; }

        [MaxLength(100)]
        public string ViTri { get; set; }

        [MaxLength(50)]
        public string ButDanh { get; set; }

        [MaxLength(500)]
        public string TenBaiViet { get; set; }

        [MaxLength(50)]
        public string LoaiBaiViet { get; set; }

        public Byte TrangThai { get; set; }

        public Decimal TyLe { get; set; }

        public int AppHangBaiVietREF { get; set; }

        public Int32 TongSoLuongAnh { get; set; }

        public Int32 TongSoLuongClip { get; set; }

        public Int32 SLClipA { get; set; }

        public Int32 SLClipB { get; set; }

        public Int32 SLClipC { get; set; }

        public Int32 SLClipSanXuat { get; set; }

        public Int32 NhuanBaiViet { get; set; }

        public Decimal HeSo { get; set; }

        public Decimal Thuong { get; set; }

        public Decimal Phat { get; set; }

        public Decimal TongNhuan { get; set; }

        [MaxLength(1000)]
        public string LinkBai { get; set; }

        [MaxLength(1000)]
        public string LinkClip { get; set; }

        public int TongView { get; set; }

        public int ViewWeb { get; set; }

        public int ViewMobile { get; set; }

        public int TongLike { get; set; }

        public int TongShare { get; set; }

        [MaxLength(5000)]
        public string GhiChu { get; set; }

        public Byte TrangThaiXyLy { get; set; }

        [MaxLength(50)]
        public string NguoiCapNhat { get; set; }

        [MaxLength(5000)]
        public string LyDoNangHang { get; set; }

        [MaxLength(5000)]
        public string LyDoThuongPhat { get; set; }

        public DateTime CreationTime { get; set; }

        [MaxLength(50)]
        public string CreatorUserId { get; set; }

        public DateTime LastModificationTime { get; set; }

        [MaxLength(50)]
        public string LastModifierUserId { get; set; }

        public bool IsDeleted { get; set; }

        [MaxLength(50)]
        public string DeleterUserId { get; set; }

        public DateTime DeletionTime { get; set; }
    }
}
