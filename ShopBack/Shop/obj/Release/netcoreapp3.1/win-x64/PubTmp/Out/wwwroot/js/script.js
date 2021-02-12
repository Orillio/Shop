$(document).ready(function () {
    $('.counter_submit').click(e => {
        var values = { productId: document.getElementById('Id').value, productQuantity: $('.counter_input')[0].value }
        $.post({
            type: "POST",
            url: "/Product/AddItem",
            data: values,
            success: addItemNotification,
        });
    });
    $('.burger').click(() => {
        if(!$('.left-toolbar').hasClass('active')){
            $('.left-toolbar').addClass('active');
            $('body').addClass('overhidden');
        }
        else{
            $('.left-toolbar').removeClass('active');
            $('body').removeClass('overhidden');
        }
    });
    $('.logo_burger .burger').click(() => {
        if(!$('.admin aside').hasClass('logo_burger_active')){
            $('.admin aside').addClass('logo_burger_active');
            $('body').addClass('overhidden');
        }
        else{
            $('.admin aside').removeClass('logo_burger_active');
            $('body').removeClass('overhidden');
        }
    });
    $('.price_filter_button').click(() => {
        var inputFrom = document.querySelector('.from');
        var inputTo = document.querySelector('.to');
        if (inputFrom.value == '') {
            inputFrom.classList.add('valid_error');
        }
        if (inputTo.value == '') {
            inputTo.classList.add('valid_error');
        }
        if (inputTo.value != '' || inputFrom.value != '')
            document.location.href = `/Product/SearchByPrice/?from=${inputFrom.value}&to=${inputTo.value}`;
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