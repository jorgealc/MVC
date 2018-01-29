$(document).ready(function () {
    $("#division1").click(function () {
        altura = $(this).height()
        anchura = $(this).width()
        $(this).height(altura * 2).width(anchura * 2);
    });
});