﻿using System.Threading.Tasks;
using Abp;
using Abp.Configuration;
using Center.Production.Configuration;
using Center.Production.Configuration.Dto;
using Center.Production.UiCustomization;
using Center.Production.UiCustomization.Dto;

namespace Center.Production.Web.UiCustomization.Metronic
{
    public class Theme12UiCustomizer : UiThemeCustomizerBase, IUiCustomizer
    {
        public Theme12UiCustomizer(ISettingManager settingManager)
            : base(settingManager, AppConsts.Theme12)
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
                        ContentSkin = await GetSettingValueAsync(AppSettings.UiManagement.ContentSkin)
                    },
                    Header = new ThemeHeaderSettingsDto
                    {
                        DesktopFixedHeader = await GetSettingValueAsync<bool>(AppSettings.UiManagement.Header.DesktopFixedHeader),
                        MobileFixedHeader = await GetSettingValueAsync<bool>(AppSettings.UiManagement.Header.MobileFixedHeader),
                        HeaderSkin = await GetSettingValueAsync(AppSettings.UiManagement.Header.Skin),
                    },
                    Menu = new ThemeMenuSettingsDto
                    {
                        AsideSkin = await GetSettingValueAsync(AppSettings.UiManagement.LeftAside.AsideSkin),
                        FixedAside = await GetSettingValueAsync<bool>(AppSettings.UiManagement.LeftAside.FixedAside),
                        AllowAsideMinimizing = await GetSettingValueAsync<bool>(AppSettings.UiManagement.LeftAside.AllowAsideMinimizing),
                        DefaultMinimizedAside = await GetSettingValueAsync<bool>(AppSettings.UiManagement.LeftAside.DefaultMinimizedAside),
                        AllowAsideHiding = await GetSettingValueAsync<bool>(AppSettings.UiManagement.LeftAside.AllowAsideHiding),
                        DefaultHiddenAside = await GetSettingValueAsync<bool>(AppSettings.UiManagement.LeftAside.DefaultHiddenAside)
                    },
                    Footer = new ThemeFooterSettingsDto
                    {
                        FixedFooter = await GetSettingValueAsync<bool>(AppSettings.UiManagement.Footer.FixedFooter)
                    }
                }
            };

            settings.BaseSettings.Theme = ThemeName;
            settings.BaseSettings.Layout.ThemeColor = settings.BaseSettings.Theme;
            
            settings.BaseSettings.Menu.Position = "left";
            settings.BaseSettings.Menu.AsideSkin = "dark";
            settings.BaseSettings.Menu.SubmenuToggle = "Accordion";

            settings.BaseSettings.Header.HeaderSkin = "dark";

            settings.IsLeftMenuUsed = true;
            settings.IsTopMenuUsed = false;
            settings.IsTabMenuUsed = false;

            return settings;
        }

        public async Task UpdateUserUiManagementSettingsAsync(UserIdentifier user, ThemeSettingsDto settings)
        {
            await SettingManager.ChangeSettingForUserAsync(user, AppSettings.UiManagement.Theme, ThemeName);

            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.LayoutType, settings.Layout.LayoutType);
            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.ContentSkin, settings.Layout.ContentSkin);
            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.Header.DesktopFixedHeader, settings.Header.DesktopFixedHeader.ToString());
            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.Header.MobileFixedHeader, settings.Header.MobileFixedHeader.ToString());
            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.Header.Skin, settings.Header.HeaderSkin);
            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.LeftAside.AsideSkin, settings.Menu.AsideSkin);
            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.LeftAside.FixedAside, settings.Menu.FixedAside.ToString());
            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.LeftAside.AllowAsideMinimizing, settings.Menu.AllowAsideMinimizing.ToString());
            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.LeftAside.DefaultMinimizedAside, settings.Menu.DefaultMinimizedAside.ToString());
            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.LeftAside.AllowAsideHiding, settings.Menu.AllowAsideHiding.ToString());
            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.LeftAside.DefaultHiddenAside, settings.Menu.DefaultHiddenAside.ToString());
            await ChangeSettingForUserAsync(user, AppSettings.UiManagement.Footer.FixedFooter, settings.Footer.FixedFooter.ToString());
        }

        public async Task UpdateTenantUiManagementSettingsAsync(int tenantId, ThemeSettingsDto settings)
        {
            await SettingManager.ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.Theme, settings.Theme);

            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.LayoutType, settings.Layout.LayoutType);
            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.ContentSkin, settings.Layout.ContentSkin);
            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.Header.DesktopFixedHeader, settings.Header.DesktopFixedHeader.ToString());
            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.Header.MobileFixedHeader, settings.Header.MobileFixedHeader.ToString());
            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.Header.Skin, settings.Header.HeaderSkin);
            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.LeftAside.AsideSkin, settings.Menu.AsideSkin);
            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.LeftAside.FixedAside, settings.Menu.FixedAside.ToString());
            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.LeftAside.AllowAsideMinimizing, settings.Menu.AllowAsideMinimizing.ToString());
            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.LeftAside.DefaultMinimizedAside, settings.Menu.DefaultMinimizedAside.ToString());
            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.LeftAside.AllowAsideHiding, settings.Menu.AllowAsideHiding.ToString());
            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.LeftAside.DefaultHiddenAside, settings.Menu.DefaultHiddenAside.ToString());
            await ChangeSettingForTenantAsync(tenantId, AppSettings.UiManagement.Footer.FixedFooter, settings.Footer.FixedFooter.ToString());
        }

        public async Task UpdateApplicationUiManagementSettingsAsync(ThemeSettingsDto settings)
        {
            await SettingManager.ChangeSettingForApplicationAsync(AppSettings.UiManagement.Theme, settings.Theme);

            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.LayoutType, settings.Layout.LayoutType);
            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.ContentSkin, settings.Layout.ContentSkin);
            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.Header.DesktopFixedHeader, settings.Header.DesktopFixedHeader.ToString());
            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.Header.MobileFixedHeader, settings.Header.MobileFixedHeader.ToString());
            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.Header.Skin, settings.Header.HeaderSkin);
            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.LeftAside.AsideSkin, settings.Menu.AsideSkin);
            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.LeftAside.FixedAside, settings.Menu.FixedAside.ToString());
            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.LeftAside.AllowAsideMinimizing, settings.Menu.AllowAsideMinimizing.ToString());
            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.LeftAside.DefaultMinimizedAside, settings.Menu.DefaultMinimizedAside.ToString());
            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.LeftAside.AllowAsideHiding, settings.Menu.AllowAsideHiding.ToString());
            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.LeftAside.DefaultHiddenAside, settings.Menu.DefaultHiddenAside.ToString());
            await ChangeSettingForApplicationAsync(AppSettings.UiManagement.Footer.FixedFooter, settings.Footer.FixedFooter.ToString());
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
                    ContentSkin = await GetSettingValueForApplicationAsync(AppSettings.UiManagement.ContentSkin)
                },
                Header = new ThemeHeaderSettingsDto
                {
                    DesktopFixedHeader = await GetSettingValueForApplicationAsync<bool>(AppSettings.UiManagement.Header.DesktopFixedHeader),
                    MobileFixedHeader = await GetSettingValueForApplicationAsync<bool>(AppSettings.UiManagement.Header.MobileFixedHeader),
                    HeaderSkin = await GetSettingValueForApplicationAsync(AppSettings.UiManagement.Header.Skin),
                },
                Menu = new ThemeMenuSettingsDto
                {
                    AsideSkin = await GetSettingValueForApplicationAsync(AppSettings.UiManagement.LeftAside.AsideSkin),
                    FixedAside = await GetSettingValueForApplicationAsync<bool>(AppSettings.UiManagement.LeftAside.FixedAside),
                    AllowAsideMinimizing = await GetSettingValueForApplicationAsync<bool>(AppSettings.UiManagement.LeftAside.AllowAsideMinimizing),
                    DefaultMinimizedAside = await GetSettingValueForApplicationAsync<bool>(AppSettings.UiManagement.LeftAside.DefaultMinimizedAside),
                    AllowAsideHiding = await GetSettingValueForApplicationAsync<bool>(AppSettings.UiManagement.LeftAside.AllowAsideHiding),
                    DefaultHiddenAside = await GetSettingValueForApplicationAsync<bool>(AppSettings.UiManagement.LeftAside.DefaultHiddenAside)
                },
                Footer = new ThemeFooterSettingsDto
                {
                    FixedFooter = await GetSettingValueForApplicationAsync<bool>(AppSettings.UiManagement.Footer.FixedFooter)
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
                    ContentSkin = await GetSettingValueForTenantAsync(AppSettings.UiManagement.ContentSkin, tenantId),
                },
                Header = new ThemeHeaderSettingsDto
                {
                    DesktopFixedHeader = await GetSettingValueForTenantAsync<bool>(AppSettings.UiManagement.Header.DesktopFixedHeader, tenantId),
                    MobileFixedHeader = await GetSettingValueForTenantAsync<bool>(AppSettings.UiManagement.Header.MobileFixedHeader, tenantId),
                    HeaderSkin = await GetSettingValueForTenantAsync(AppSettings.UiManagement.Header.Skin, tenantId),
                },
                Menu = new ThemeMenuSettingsDto
                {
                    AsideSkin = await GetSettingValueForTenantAsync(AppSettings.UiManagement.LeftAside.AsideSkin, tenantId),
                    FixedAside = await GetSettingValueForTenantAsync<bool>(AppSettings.UiManagement.LeftAside.FixedAside, tenantId),
                    AllowAsideMinimizing = await GetSettingValueForTenantAsync<bool>(AppSettings.UiManagement.LeftAside.AllowAsideMinimizing, tenantId),
                    DefaultMinimizedAside = await GetSettingValueForTenantAsync<bool>(AppSettings.UiManagement.LeftAside.DefaultMinimizedAside, tenantId),
                    AllowAsideHiding = await GetSettingValueForTenantAsync<bool>(AppSettings.UiManagement.LeftAside.AllowAsideHiding, tenantId),
                    DefaultHiddenAside = await GetSettingValueForTenantAsync<bool>(AppSettings.UiManagement.LeftAside.DefaultHiddenAside, tenantId)
                },
                Footer = new ThemeFooterSettingsDto
                {
                    FixedFooter = await GetSettingValueForTenantAsync<bool>(AppSettings.UiManagement.Footer.FixedFooter, tenantId)
                }
            };
        }
    }
}