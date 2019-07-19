using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Center.Production.BanHang.TinTuc.Dto
{
    public class TinTucDto: EntityDto<long>
    {
        TinTucDto()
        {
            NgaySua = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }
        public string TieuDe { get; set; }
        
        public string NoiDung { get; set; }

        public int UserId { get; set; }

        public int DanhMucId { get; set; }

        public int TrangThai { get; set; }

        public string NgayThem { get; set; }

        public string NgaySua { get; set; }
    }
    public class XoaTinTucDto: EntityDto<long>
    {
        public int TrangThai { get; set; }

        // 0: thay đổi trạng thái , 1 xóa vĩnh viễn
        public int IsDelete { get; set; }
    }
}
