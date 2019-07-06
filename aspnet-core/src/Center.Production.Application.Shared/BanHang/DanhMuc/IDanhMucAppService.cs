using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Center.Production.BanHang.DanhMuc.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Center.Production.BanHang.DanhMuc
{
    public interface IDanhMucAppService : IApplicationService
    {
        Task<PagedResultDto<DanhMucDto>> GetDanhMuc(DanhMucInput input);
    }
}
