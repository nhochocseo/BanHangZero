using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Center.Production.Configuration.Host.Dto;
using Center.Production.Editions.Dto;

namespace Center.Production.Web.Areas.AppAreaName.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}