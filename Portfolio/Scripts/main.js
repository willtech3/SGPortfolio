/**
 * Created by William on 8/20/2014.
 */
(function () {
    $(document).ready(function () {
        $('a[href^="#"]').on('click', function (e) {
            e.preventDefault();

            var target = this.hash,
            $target = $(target);

            $('html, body').stop().animate({
                'scrollTop': $target.offset().top
            }, 900, 'swing', function () {
                window.location.hash = target;
            });
        });
        smallImg("#linkedin", "../Content/Images/Linkedin_sm.png");
        smallImg("#facebook", "../Content/Images/facebook_sm.png");

        $("#Seth").hide().fadeIn(1500);

    });

    
    var webFontConfig = {
        google: { families: [ 'Allerta::latin' ] }
    };
    (function() {
        var wf = document.createElement('script');
        wf.src = ('https:' == document.location.protocol ? 'https' : 'http') +
          '://ajax.googleapis.com/ajax/libs/webfont/1/webfont.js';
        wf.type = 'text/javascript';
        wf.async = 'true';
        var s = document.getElementsByTagName('script')[0];
        s.parentNode.insertBefore(wf, s);
    })();

    $(window).resize(function () {
        smallImg("#linkedin", "../Content/Images/Linkedin_sm.png");
        smallImg("#facebook", "../Content/Images/facebook_sm.png");
    });


    function smallImg(targetClass, imageSrc) {
        var width = window.innerWidth;
        if (width < 992) {
            $(targetClass).attr("src", imageSrc);
        }
        else {
            if (targetClass == "#facebook") {
                $(targetClass).attr("src", "../Content/Images/facebook.png");
            }
                
            if (targetClass == "#linkedin") {
                $(targetClass).attr("src", "../Content/Images/Linkedin.png");
            }
        }
    }

    $(".pw").on('click', function () {
        $('.water').css("background-image", "url(../Content/Images/picwave_mock.jpg)").hide().fadeIn('slow');
        $('.water').css("background-attachment", "scroll");
        clearNavAndLogo();
    });

    $(".rr").on('click', function() {
        $('.water').css("background-image", "url(../Content/Images/reviewrhino.jpg)").hide().fadeIn('slow');
        $('.water').css("background-attachment", "scroll");
        clearNavAndLogo();
    });

    $(".adv").on('click', function() {
        $('.water').css("background-image", "url(../Content/Images/advlarge.jpg)").hide().fadeIn('slow');
        $('.water').css("background-attachment", "scroll");
        clearNavAndLogo();
    });

    $(".advff").on('click', function() {
        $('.water').css("background-image", "url(../Content/Images/afa.jpg)").hide().fadeIn('slow');
        $('.water').css("background-attachment", "scroll");
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
        $('.water').css("background-attachment", "fixed");
        $("#back").addClass('hidden');
        $("#nav").fadeIn(500);
        $("#Seth").fadeIn(500);
        $("#logo").fadeIn(500);
    }
})();