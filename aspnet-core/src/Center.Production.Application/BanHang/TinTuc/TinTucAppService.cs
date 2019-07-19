using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Center.Production.Authorization;
using Center.Production.BanHang.TinTuc.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace Center.Production.BanHang.TinTuc
{
    [AbpAuthorize(AppPermissions.Pages_TinTuc)]
    public class TinTucAppService: ProductionAppServiceBase
    {
        private readonly IRepository<TinTuc> _tinTucReponsitory;
        public TinTucAppService(
                IRepository<TinTuc> tintucReponsitory
            )
        {
            _tinTucReponsitory = tintucReponsitory;
        }

        #region GetDanhSach
        public async Task<PagedResultDto<TinTucDto>> GetDanhSach(TinTucInput input)
        {
            var query = _tinTucReponsitory.GetAll().WhereIf(
                !string.IsNullOrWhiteSpace(input.Filter),
                t => t.TieuDe.Contains(input.Filter) || t.NoiDung.Contains(input.Filter)
                );

            var tinTucCount = await query.CountAsync();

            var tinTuc = await query
                            .OrderBy(input.Sorting ?? "id ASC")
                            .PageBy(input)
                            .ToListAsync();
            var tintucDto = ObjectMapper.Map<List<TinTucDto>>(tinTuc);
            return new PagedResultDto<TinTucDto>(
                 tinTucCount,
                 tintucDto
                );
        }
        #endregion

        #region SaveTinTuc
        public async Task<int> SaveTinTuc(TinTucDto input)
        {
            var check = _tinTucReponsitory.FirstOrDefault(d => d.Id == input.Id);
            if (check != null)
            {
                check.TieuDe = input.TieuDe;
                check.NoiDung = input.NoiDung;
                check.NgaySua = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                check.TrangThai = input.TrangThai;
                await _tinTucReponsitory.UpdateAsync(check);
                return 1;
            } else
            {
                input.Id = ConstTrangThaiTinTuc.ThemMoi;
                input.TrangThai = ConstTrangThaiTinTuc.ThemMoi;
                input.NgayThem = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                input.NgaySua = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                var tintuc = ObjectMapper.Map<TinTuc>(input);
                await _tinTucReponsitory.InsertAsync(tintuc);
                return 0;
            }
        }
        #endregion

        #region Change Trạng thái
        public async Task<int> ChangeTrangThai(XoaTinTucDto input)
        {
            var check = _tinTucReponsitory.FirstOrDefault(t => t.Id == input.Id);
            if (check != null)
            {
                if (input.TrangThai != check.TrangThai && input.IsDelete == 0)
                {
                    check.TrangThai = input.TrangThai;
                    await _tinTucReponsitory.UpdateAsync(check);
                    return 1;
                } else
                {
                    await _tinTucReponsitory.DeleteAsync(check);
                    return 2;
                }
            }
            return 0;
        }
        #endregion
    }

}
