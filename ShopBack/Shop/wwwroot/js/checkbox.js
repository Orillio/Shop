$(document).ready(function () {
    if (!$('.admin_checkbox')[0].checked){
        $('.discount_readonly').attr('readonly', '');
        $('.discount_readonly')[0].value = '';
    }
    else{
        $('.discount_readonly').removeAttr('readonly');
    }
    $('.checkbox_label').click(() => check());
    
});
function percentValidate(s, event){
    var rep = /[0-9]/
    if (!rep.test(event.key)) {
        if (event.key != 'Backspace') {
            return false;
        }
    }
    var value = $('.discount_readonly')[0].value;
    if(+(`${value}` + event.key) > 100) return false;
}
function priceValidate(s, event){
    var rep = /[0-9]/
    if (!rep.test(event.key)) {
        if (event.key != 'Backspace') {
            return false;
        }
    }
}
function check(){
    if ($('.admin_checkbox')[0].checked){
        $('.discount_readonly').attr('readonly', '');
        $('.discount_readonly')[0].value = '';
    }
    else{
        $('.discount_readonly').removeAttr('readonly');
    }
}