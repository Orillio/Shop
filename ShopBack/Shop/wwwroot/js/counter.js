$(document).ready(function () 
{
    $('.button_plus').click(e => 
    {
        var val = e.currentTarget.parentElement.children[1].value;
        if (val >= 99) return;
        e.currentTarget.parentElement.children[1].value++;
    });
    $('.button_minus').click(e => 
    {
        var val = e.currentTarget.parentElement.children[1].value;
        if (val <= 1) return;
        e.currentTarget.parentElement.children[1].value--;
    });
});
function specialText(element, event)
{
    console.log(event);
    console.log(event.key);
    var rep = /[0-9]/
    if (!rep.test(event.key)) {
        if(event.key != 'Backspace')
            return false;
    }
}