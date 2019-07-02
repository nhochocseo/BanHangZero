using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Center.Production.BanHang.DanhMuc.Dto
{
    public interface IgetDanhMucInput : ISortedResultRequest
    {
        string Filter { get; set; }

        string Permission { get; set; }

        int? Role { get; set; }

        bool OnlyLockedUsers { get; set; }
    }
}
