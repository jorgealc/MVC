	
$('input.checkbox:checkbox').change(function () {
    if ($(this).prop('checked') == true) {
        alert("checked")
        if ($(this).prop('checked') == false) {
            alert("inchecked")


            return;

        }
    }
});
 
    