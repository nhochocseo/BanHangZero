using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Center.Production.Editions.Dto;

namespace Center.Production.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}