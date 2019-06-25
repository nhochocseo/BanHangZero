using Abp.Authorization;
using Center.Production.Authorization;
using Center.Production.BanHang.Dto;
using Center.Production.BanHang.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center.Production.BanHang.DanhMuc
{
    [AbpAuthorize(AppPermissions.Pages_DanhMuc)]
    public class DanhMucAppService : ProductionAppServiceBase, IDanhMucAppSerrvice
    {
        public DanhMucAppService()
        {

        }

        public int Save(Dto.DanhMuc input)
        {
            var a = 1;
            return a;
        }
    }
}
