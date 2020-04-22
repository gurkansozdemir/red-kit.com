$(".lesson").on('click', function (event) {
    debugger
    var url = $(this).attr("data-url");
    var currentId = sessionStorage.getItem("id");
    if (currentId != null) {
        window.location.href = url;
    }
    else {
        $('#exampleModal').modal('show');
    }
});

$('.lesson').hover(function () {
    $(this).css('cursor', 'pointer');
});