$(document).ready(function () {
    $('.filter_button').click(e =>
    {
        if($('.filter_button').hasClass('filter_active'))
        {
            e.currentTarget.classList.remove('filter_active');
        }
        else
        {
            e.currentTarget.classList.add('filter_active');
        }
    });
});