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
            success: function (data) {
                addItemNotification();

            },
        });
    });
    function countAll(e)
    {
    }
    function addItemNotification() {
        var wrapper = document.createElement('li');
        wrapper.classList.add("notifications_list__item");
        wrapper.innerHTML = 
            `<div class="greendot_container"></div>
            <span>Товар добавлен в корзину</span>`;
        var list = document.querySelector(".notifications_list");
        list.prepend(wrapper);
        $(wrapper).animate({ opacity: 1 }, 200, "linear", setTimeout(function () {
            $(wrapper).animate({ opacity: 0 }, 200, "linear", null);
            setTimeout(function () {
                wrapper.remove();
            },500)
        }, 4000));
        
    }
});