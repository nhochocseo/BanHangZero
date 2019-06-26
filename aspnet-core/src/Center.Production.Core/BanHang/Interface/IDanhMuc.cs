using Center.Production.BanHang.Dto;
using System;
using System.Collections.Generic;

namespace Center.Production.BanHang.Interface
{
    public interface IDanhMuc
    {
        int Save(Dto.DanhMucDto data);
        List<Dto.DanhMucDto> GetList();
    }
}
