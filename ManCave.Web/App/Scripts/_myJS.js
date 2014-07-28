var jumboHeight = $('.jumbotron').outerHeight();
function parallax() {
    var scrolled = $(window).scrollTop();
    $('.body').css('height', (jumboHeight - scrolled) + 'px');
}

$(window).scroll(function (e) {
    parallax();
});