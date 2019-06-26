using Abp.Dependency;
using Abp.Domain.Repositories;
using AutoMapper;
using Center.Production.BanHang.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Center.Production.BanHang.Service
{
    public class DanhMucService : Interface.IDanhMuc, ITransientDependency
    {
        private readonly IRepository<DanhMuc.DanhMuc> _danhMucRepository;
        public DanhMucService(
            IRepository<DanhMuc.DanhMuc> danhMucRepository
            )
        {
            _danhMucRepository = danhMucRepository;
        }
        public int Save(Dto.DanhMucDto data)
        {
            if(data.Id != null)
            {
                _danhMucRepository.InsertAsync(Mapper.Map<DanhMuc.DanhMuc>(data));
                return 0;
            }
            _danhMucRepository.UpdateAsync(Mapper.Map<DanhMuc.DanhMuc>(data));
            return 1;
        }
        public List<Dto.DanhMucDto> GetList()
        {
            var data = Mapper.Map<List<DanhMucDto>>(_danhMucRepository.GetAll().ToList());
            return data;
        }
    }
}
