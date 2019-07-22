using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Center.Production.BanHang.Dto;
using Center.Production.BanHang.QuanLyNhuan.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Center.Production.BanHang.QuanLyNhuan
{
    public interface IQuanLyNhuanService : IApplicationService
    {
        Task<PagedResultDto<AppQuanLyNhuanDto>> GetQuanLyNhuan(DtoInput input);
    }
}
