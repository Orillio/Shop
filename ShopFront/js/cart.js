$(document).ready(function () {
    countAll();
    $('.counter_input').blur(e => postAndCalc(e.currentTarget.parentElement.parentElement.parentElement));
    $('.action_button').click(e => {
        product = e.currentTarget.parentElement.parentElement.parentElement;
        postAndCalc(product);
    });
    $('.product_delete').click(e => {
        var product = e.currentTarget.parentElement;
        $(product).animate({ height: 0 }, 100, "linear", function () {
            product.remove();
            totalCount();
            $.ajax({
                url: "/Product/DeleteItem",
                type: "DELETE",
                data: { productId: product.id}
            })
        });
    });
    
    function countAll() {
        document.querySelectorAll('.product__item').forEach(product => {
            productCalc(product);
        });
        totalCount();
    }
    function totalCount() {
        var total = 0;
        document.querySelectorAll('.product__item').forEach(product => {
            total += Number(product.querySelector('.product_total').innerText.split(' ')[0]);
        });
        document.querySelector('.sum_price').innerText = `${total} руб`;
    }
    function productCalc(product) {
        var price = product.querySelector('.price');
        var productTotal = product.querySelector('.product_total');
        var quantity = product.querySelector('.counter_input');
        productTotal.innerText = `${Number(quantity.value) * Number(price.innerText.split(' ')[0])} руб`;
    }
    function postAndCalc(product) {
        productCalc(product);
        var values = { productId: product.id, productQuantity: product.querySelector('.counter_input').value };
        $.post({
            type: "POST",
            url: "/Product/SetItemQuantity",
            data: values,
        });
        totalCount();
    }
});