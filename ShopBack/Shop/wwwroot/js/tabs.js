$(document).ready(function () {
    $('.tabs li').click(function(e) {
        let tab = $(this);
        let tabAttr = tab.attr('data-tab');
        if(tab.hasClass('current')) return;
        $('.tabs li').each(function() {
            $(this).removeClass('current')
        });
        tab.addClass('current');
        $('.tabs_content .tab_block').each(function() {
            $(this).removeClass('current');
        });
        $(`.tabs_content #${tabAttr}`).addClass('current');
    });
});