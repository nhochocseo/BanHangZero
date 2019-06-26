using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center.Production.BanHang.DanhMuc
{
    public class DanhMuc : Entity
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Url { get; set; }
        public int ParentId { get; set; }
    }
}
