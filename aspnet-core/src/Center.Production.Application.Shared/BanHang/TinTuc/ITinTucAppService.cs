using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Center.Production.BanHang.TinTuc.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Center.Production.BanHang.TinTuc
{
    public interface  ITinTucAppService: IApplicationService
    {
        Task<PagedResultDto<TinTucDto>> GetDanhSach(TinTucInput input);
    }
}
