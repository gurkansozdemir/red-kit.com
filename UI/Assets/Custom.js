﻿$(".lesson").on('click', function (event) {
    debugger
    var url = $(this).val();
    var currentId = sessionStorage.getItem("id");
    if (currentId != null) {
        window.location.href = url;
    }
    else {
        // modal.show();
    }
});

$('.lesson').hover(function () {
    $(this).css('cursor', 'pointer');
});