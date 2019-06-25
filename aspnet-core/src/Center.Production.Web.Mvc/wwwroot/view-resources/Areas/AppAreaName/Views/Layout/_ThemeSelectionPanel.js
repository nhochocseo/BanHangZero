$(function () {
    var _uiCustomizationSettingsService = abp.services.app.uiCustomizationSettings;

    var quickSidebarOffCanvas = new mOffcanvas('m_theme_selection_panel', {
        baseClass: 'm-quick-sidebar',
        closeBy: 'm_theme_selection_panel_close',
        toggleBy: 'm_theme_selection_panel_toggle'
    });

    // run once on first time dropdown shown
    quickSidebarOffCanvas.one('afterShow', function () {
        mApp.block($('#m_theme_selection_panel'));

        setTimeout(function () {
            mApp.unblock($('#m_theme_selection_panel'));
            $('#m_theme_selection_panel').find('.m-theme-selection-panel__content').removeClass('m--hide');
        }, 1000);
    });

    $('#m_theme_selection_panel .m-scrollable').slimScroll({ destroy: true });
    $('#m_theme_selection_panel .m-scrollable').slimScroll({
        height: $(window).height() - 20
    });

    $('.theme-selection-link').click(function () {
        var theme = $(this).data('theme');
        _uiCustomizationSettingsService.changeThemeWithDefaultValues(theme).done(function () {
            window.location.reload();
        });
    });
});