$(document).ready(function () {
    $('.button_plus').click(e => {
        var val = e.currentTarget.parentElement.children[1].value;
        if (val >= 99) return;
        e.currentTarget.parentElement.children[1].value++;
    });
    $('.button_minus').click(e => {
        var val = e.currentTarget.parentElement.children[1].value;
        if (val <= 1) return;
        e.currentTarget.parentElement.children[1].value--;
    });
});
function specialText(element, event) {
    console.log(event);
    console.log(event.key);
    var rep = /[0-9]/
    if (!rep.test(event.key)) {
        if (event.key != 'Backspace')
            return false;
    }
}
function onblurCounter(e) {
    if (e.value == '0' || e.value == '') { e.value = 1; }
    else if (e.value[0] == '0') { e.value = e.value[1] }
}