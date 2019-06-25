using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Center.Production.BanHang.Dto
{
    public class DanhMuc : Entity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int ParentId { get; set; }
    }
}
