using System.Threading.Tasks;
using Abp;
using Abp.Configuration;
using Center.Production.Configuration;
using Center.Production.Configuration.Dto;
using Center.Production.UiCustomization;
using Center.Production.UiCustomization.Dto;

namespace Center.Production.Web.UiCustomization.Metronic
{
    public class Theme4UiCustomizer : UiThemeCustomizerBase, IUiCustomizer
    {
        public Theme4UiCustomizer(ISettingManager settingManager)
            : base(settingManager, AppConsts.Theme4)
        {
        }

        public async Task<UiCustomizationSettingsDto> GetUiSettings()
        {
            var settings = new UiCustomizationSettingsDto
            {
                BaseSettings = new ThemeSettingsDto
                {
                    Layout = new ThemeLayoutSettingsDto
                    {
                        LayoutType = await GetSettingValueAsync(AppSettings.UiManagement.LayoutType),
                        FixedBody = await GetSettingValueAsync<bool>(AppSettings.UiManagement.FixedBody),
                        MobileFixedBody = await GetSettingValueAsync<bool>(AppSettings.UiManagement.MobileFixedBody)
                    }
                }
            };

            settings.BaseSettings.Theme = ThemeName;
            settings.BaseSettings.Layout.ThemeColor = settings.BaseSettings.Theme;
            settings.BaseSettings.Menu.Position = "top";
            settings.BaseSettings.Menu.AsideSkin = "light";

            settings.BaseSettings.Header.DesktopFixedHeader = false;
            settings.BaseSettings.Header.MobileFixedHeader = false;

            settings.IsLeftMenuUsed = false;
            settings.IsTopMenuUsed = true;
            settings.IsTabMenuUsed = false;

            return settings;
        }

        public async Task UpdateUserUiManagementSettingsAsync(UserIdentifier user, ThemeSettingsDto settings)
        {
            await SettingManager.ChangeSettingForUserAsync(user, AppSettings.UiManagement.Theme, ThemeName);

            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.LayoutType, settings.Layout.LayoutType);
            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.FixedBody, settings.Layout.FixedBody.ToString());
            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.MobileFixedBody, settings.Layout.MobileFixedBody.ToString());
        }

        public async Task UpdateTenantUiManagementSettingsAsync(int tenantId, ThemeSettingsDto settings)
        {
            await SettingManager.ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.Theme, ThemeName);

            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.LayoutType, settings.Layout.LayoutType);
            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.FixedBody, settings.Layout.FixedBody.ToString());
            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.MobileFixedBody, settings.Layout.MobileFixedBody.ToString());
        }

        public async Task UpdateApplicationUiManagementSettingsAsync(ThemeSettingsDto settings)
        {
            await SettingManager.ChangeSettingForApplicationAsync(AppSettings.UiManagement.Theme, ThemeName);

            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.LayoutType, settings.Layout.LayoutType);
            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.FixedBody, settings.Layout.FixedBody.ToString());
            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.MobileFixedBody, settings.Layout.MobileFixedBody.ToString());
        }

        public async Task<ThemeSettingsDto> GetHostUiManagementSettings()
        {
            var theme = await SettingManager.GetSettingValueForApplicationAsync(AppSettings.UiManagement.Theme);

            return new ThemeSettingsDto
            {
                Theme = theme,
                Layout = new ThemeLayoutSettingsDto
                {
                    LayoutType = await GetSettingValueForApplicationAsync(AppSettings.UiManagement.LayoutType),
                    FixedBody = await GetSettingValueForApplicationAsync<bool>(AppSettings.UiManagement.FixedBody),
                    MobileFixedBody = await GetSettingValueForApplicationAsync<bool>(AppSettings.UiManagement.MobileFixedBody)
                }
            };
        }

        public async Task<ThemeSettingsDto> GetTenantUiCustomizationSettings(int tenantId)
        {
            var theme = await SettingManager.GetSettingValueForTenantAsync(AppSettings.UiManagement.Theme, tenantId);

            return new ThemeSettingsDto
            {
                Theme = theme,
                Layout = new ThemeLayoutSettingsDto
                {
                    LayoutType = await GetSettingValueForTenantAsync(AppSettings.UiManagement.LayoutType, tenantId),
                    FixedBody = await GetSettingValueForTenantAsync<bool>(AppSettings.UiManagement.FixedBody, tenantId),
                    MobileFixedBody = await GetSettingValueForTenantAsync<bool>(AppSettings.UiManagement.MobileFixedBody, tenantId)
                }
            };
        }
    }
}