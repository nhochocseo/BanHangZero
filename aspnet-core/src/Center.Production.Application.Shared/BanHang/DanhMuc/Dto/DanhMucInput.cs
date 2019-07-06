using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Center.Production.BanHang.DanhMuc.Dto
{
    public class DanhMucInput: PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
