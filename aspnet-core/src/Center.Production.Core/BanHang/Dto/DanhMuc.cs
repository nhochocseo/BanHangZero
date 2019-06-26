using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Center.Production.BanHang.Dto
{
    public class DanhMucDto : EntityDto<int?>
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int ParentId { get; set; }
    }
}
