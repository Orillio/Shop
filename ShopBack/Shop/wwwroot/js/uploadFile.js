function onChange() {
    var input = document.getElementById('file');
    var files = input.files; 
    if (files.length == 0) return;
    var f = files[0];
    if (!f.type.match('image.*')) {
        alert("Pass only image");
        input.value = '';
        return;
    }
    var reader = new FileReader();
    reader.readAsDataURL(f);
    reader.onload = function(e) {
        var span = document.getElementById('file_input_image');
        span.innerHTML = `<img width="250px" style="margin-top: 15px;" src="${e.target.result}"/>`
    }
}