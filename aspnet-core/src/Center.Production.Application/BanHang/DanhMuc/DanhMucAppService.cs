

using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Center.Production.Authorization;
using Center.Production.BanHang.DanhMuc.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace Center.Production.BanHang.DanhMuc
{
    [AbpAuthorize(AppPermissions.Pages_DanhMuc)]
    public class DanhMucAppService : ProductionAppServiceBase, IDanhMucAppService
    {
        private readonly IRepository<DanhMuc> _danhMucRepository;
        public DanhMucAppService(
            IRepository<DanhMuc> danhMucRepository
            )
        {
            _danhMucRepository = danhMucRepository;
        }
        public async Task<PagedResultDto<DanhMucDto>> GetDanhMuc(DanhMucInput input)
        {
            var query = _danhMucRepository.GetAll().WhereIf(
                    !string.IsNullOrWhiteSpace(input.Filter),
                    d => d.Name.Contains(input.Filter) || d.Url.Contains(input.Filter));

            var danhMucCount = await query.CountAsync();

            var danhMuc = await query
                .OrderBy(input.Sorting ?? "id ASC")
                .PageBy(input)
                .ToListAsync();

            var danhMucDtos = ObjectMapper.Map<List<DanhMucDto>>(danhMuc);
            
            return new PagedResultDto<DanhMucDto>(
                danhMucCount,
                danhMucDtos
                );
        }
    }
}
