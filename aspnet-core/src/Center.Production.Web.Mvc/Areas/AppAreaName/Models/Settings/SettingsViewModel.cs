using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Center.Production.Configuration.Tenants.Dto;

namespace Center.Production.Web.Areas.AppAreaName.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}