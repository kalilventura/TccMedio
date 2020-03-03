jQuery(document).ready(function () {
    jQuery('.nav-display').on('click', function () {
        if (jQuery('.nav-display').hasClass('ativo')) {
            jQuery(this).removeClass('ativo');
            jQuery('#menu-mobile div').slideUp();
        } else {
            jQuery(this).addClass('ativo');
            jQuery('#menu-mobile div').slideDown();
        }
        return false;
    });
});


// You can also use "$(window).load(function() {"
$(function () {
    // Slideshow 4
    $("#slider").responsiveSlides({
        auto: true,
        pager: false,
        nav: true,
        speed: 500,
        namespace: "callbacks",
        before: function () {
            $('.events').append("<li>before event fired.</li>");
        },
        after: function () {
            $('.events').append("<li>after event fired.</li>");
        }
    });

});
// Light Box
$(document).ready(function () {
    $('.fancybox').fancybox();
});