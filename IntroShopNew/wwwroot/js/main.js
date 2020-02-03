console.log("Works");
$('.main-menu ul:first-child').clone().appendTo('.responsive-nav');
$('#responsive-nav-button').click(function (event) {
    event.preventDefault();
    $('.responsive-nav').slideToggle();
});