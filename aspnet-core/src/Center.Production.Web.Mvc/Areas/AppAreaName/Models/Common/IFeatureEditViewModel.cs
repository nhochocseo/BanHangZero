using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Center.Production.Editions.Dto;

namespace Center.Production.Web.Areas.AppAreaName.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}