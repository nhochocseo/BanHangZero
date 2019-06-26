using Abp.Application.Services;
using Center.Production.BanHang.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Center.Production.BanHang.Interface
{
    public interface IDanhMucAppSerrvice: IApplicationService
    {
      int Save(Dto.DanhMucDto data);
      List<Dto.DanhMucDto> GetList();
    }
}
