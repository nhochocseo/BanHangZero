using Abp.Authorization;
using Abp.Domain.Repositories;
using AutoMapper;
using Center.Production.Authorization;
using Center.Production.BanHang.Dto;
using Center.Production.BanHang.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Center.Production.BanHang.DanhMuc
{
    [AbpAuthorize(AppPermissions.Pages_DanhMuc)]
    public class DanhMucAppService : ProductionAppServiceBase, IDanhMucAppSerrvice
    {
        private readonly IDanhMuc _danhMuc;
        private readonly IRepository<DanhMuc> _danhMucIRepository;
        public DanhMucAppService(
                IDanhMuc danhMuc,
                IRepository<DanhMuc> danhMucRepository
            )
        {
            _danhMuc = danhMuc;
            _danhMucIRepository = danhMucRepository;
        }

        public int Save(Dto.DanhMucDto data)
        {
            var result = _danhMuc.Save(data);
            return result;
        }
        public List<Dto.DanhMucDto> GetList()
        {
            var data = _danhMuc.GetList();
            return data;
        }
    }
}
