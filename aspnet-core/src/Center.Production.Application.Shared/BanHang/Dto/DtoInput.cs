using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Center.Production.BanHang.Dto
{
    public class DtoInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
