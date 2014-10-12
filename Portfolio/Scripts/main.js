/**
 * Created by William on 8/20/2014.
 */
(function () {
    $(document).ready(function () {
        $('a[href^="#"]').on('click', function (e) {
            e.preventDefault();

            var target = this.hash,
            $target = $(target);

            console.log(target);
            console.log($(target));

            $('html, body').stop().animate({
                'scrollTop': $target.offset().top
            }, 900, 'swing', function () {
                window.location.hash = target;
            });
        });

        $("#Seth").hide().fadeIn(1500);
    });

    $(".pw").on('click', function () {
        $('.water').css("background-image", "url(../Content/Images/picwave_mock.jpg)").hide().fadeIn('slow');
        clearNavAndLogo();
    });

    $(".rr").on('click', function() {
        $('.water').css("background-image", "url(../Content/Images/reviewrhino.jpg)").hide().fadeIn('slow');
        clearNavAndLogo();
    });

    $("#back").on('click', function() {
        addNavAndLogo();
    });

    $("#contactme").on('click', function() {
        $(".buttonContainer").hide().fadeOut('slow');
        $(".pushDown").hide().fadeOut('slow');
        $("#inquiry").hide().removeClass("hidden");
        $("#inquiry").fadeIn(2000);
    });

    $("#cancel").on('click', function (event) {
        event.preventDefault();
        $("#inquiry").hide().addClass("hidden");
        $(".buttonContainer").hide().fadeIn('slow');
        $(".pushDown").hide().fadeIn('slow');
    });

    var validate = $('#inquiry').validate({
        // your rules & options
    });

    $("#resume").on('click', function() {
        window.open("Home/Resume", "My resume");
    });

    var clearNavAndLogo = function() {
        $("#back").removeClass('hidden');
        $("#nav").hide();
        $("#Seth").hide();
        $("#logo").hide();
    };

    var addNavAndLogo = function() {
        $('.water').css("background-image", "url(../Content/Images/bkg.jpg)").hide().fadeIn(500);
        $("#back").addClass('hidden');
        $("#nav").fadeIn(500);
        $("#Seth").fadeIn(500);
        $("#logo").fadeIn(500);
    }
})();