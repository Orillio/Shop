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
    $('.action_button').click(e => {
        if (!$(e.target).hasClass('product_delete')) {
            product = e.target.parentElement.parentElement.parentElement;
            var price = product.children[1].children[1].children[0];
            var productTotal = product.children[2].children[1];
            var quantity = product.children[2].children[0].children[1];
        }
        else {
        }
    });
    $('.counter_submit').click(e => {
        var values = { productId: window.location.pathname.split('/')[3], productQuantity: $('.counter_input')[0].value }
        $.post({
            type: "POST",
            url: "",
            data: values,
            success: values,
        });
    });
    function countAll(e)
    {
    }
    function addItemNotification () {

    }
});