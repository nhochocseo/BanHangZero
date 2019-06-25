using System.Collections.Generic;
using Center.Production.Caching.Dto;

namespace Center.Production.Web.Areas.AppAreaName.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}