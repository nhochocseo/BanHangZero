using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Center.Production.BanHang.DanhMuc.Dto
{
    public class DanhMucDto : EntityDto<long>
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int ParentId { get; set; }
        public DateTime Created { get; set; }
    }
}
