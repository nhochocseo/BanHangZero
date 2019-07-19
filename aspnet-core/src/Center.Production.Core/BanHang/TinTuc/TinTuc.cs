using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center.Production.BanHang.TinTuc
{
    public class TinTuc : Entity
    {
        [MaxLength(250)]
        public string TieuDe { get; set; }

        [MaxLength(5000)]
        public string NoiDung { get; set; }

        public int UserId { get; set; }

        public int DanhMucId { get; set; }

        public int TrangThai { get; set; }

        public string NgayThem { get; set; }

        public string NgaySua { get; set; }

    }
}
