$(document).ready(function () {
    $('.filter_button').click(e => {
        if ($('.filter_button_arrow').hasClass('filter_active')) {
            e.currentTarget.children[1].classList.remove('filter_active');
        }
        else {
            e.currentTarget.children[1].classList.add('filter_active');
        }
    });
    $('.filter__name').click(e => {
        if ($(e.currentTarget.children[1]).hasClass('filter_active')) {
            e.currentTarget.children[1].classList.remove('filter_active');
        }
        else {
            e.currentTarget.children[1].classList.add('filter_active');
        }
    });
    $('.counter_submit').click(e => {
        var values = { productId: window.location.pathname.split('/')[3], productQuantity: $('.counter_input')[0].value }
        $.post({
            type: "POST",
            url: "/Product/AddItem",
            data: values,
            success: addItemNotification,
        });
    });
    
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
            }, 500)
        }, 4000));
    }
    var tabList = document.querySelectorAll('.tabs__item');

    tabList.forEach(item => {
        item.addEventListener('click', tabActiveAdd);
    });

    function tabActiveAdd() {
        tabList.forEach(item => {
            item.classList.remove('tab_active');
        });
        this.classList.add('tab_active');
        document.querySelectorAll('.tab-block').forEach(item => {
            item.classList.remove('tab_block_active');
        });
        document.querySelector(`.${this.getAttribute('data-tab')}`).classList.add('tab_block_active');
    }
});