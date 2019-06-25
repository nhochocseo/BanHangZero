using System.Collections.Generic;
using Abp.Localization;
using Center.Production.Install.Dto;

namespace Center.Production.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
