

using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Center.Production.Authorization;
using Center.Production.BanHang.Dto;
using Center.Production.BanHang.QuanLyNhuan.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace Center.Production.BanHang.QuanLyNhuan
{
    [AbpAuthorize(AppPermissions.Pages_QuanLyNhuan)]
    public class QuanLyNhuanService : ProductionAppServiceBase, IQuanLyNhuanService
    {
        private readonly IRepository<AppQuanLyNhuan> _quanLyNhuanRepository;
        public QuanLyNhuanService(
            IRepository<AppQuanLyNhuan> quanLyNhuanRepository)
        {
            _quanLyNhuanRepository = quanLyNhuanRepository;
        }
        public async Task<PagedResultDto<AppQuanLyNhuanDto>> GetQuanLyNhuan(DtoInput input)
        {
            
            var query = _quanLyNhuanRepository.GetAll().WhereIf(
                !string.IsNullOrWhiteSpace(input.Filter),
                q => q.ButDanh.Contains(input.Filter) || q.ChuyenMuc.Contains(input.Filter)
                );
            var quanLyNhuanCount = await query.CountAsync();

            var quanLyNhuan = await query
                .OrderBy(input.Sorting ?? "id ASC")
                .PageBy(input)
                .ToListAsync();

            var danhMucDtos = ObjectMapper.Map<List<AppQuanLyNhuanDto>>(quanLyNhuan);

            return new PagedResultDto<AppQuanLyNhuanDto>(
                quanLyNhuanCount,
                danhMucDtos
                );
        }
    }
}
