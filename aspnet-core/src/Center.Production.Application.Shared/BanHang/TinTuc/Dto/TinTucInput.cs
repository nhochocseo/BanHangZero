using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Center.Production.BanHang.TinTuc.Dto
{
    public class TinTucInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
