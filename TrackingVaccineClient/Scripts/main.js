/*------------

  Template Name:  Curex - Medical Clinic Service Bootstrap 5 Template
  Description: Curex is a unique website template designed in HTML with a simple & beautiful look. There is an excellent solution for creating clean, wonderful and trending material design Medical, Clinic any other purposes websites.
  Version: 2.0.0 
-----------------*/


(function ($) {
    'use strict';
    /**************************
   * Offcanvas: Menu Content
   **************************/
    function mobileOffCanvasMenu() {
        var $offCanvasNav = $('.offcanvas-menu'),
            $offCanvasNavSubMenu = $offCanvasNav.find('.mobile-sub-menu');

        /*Add Toggle Button With Off Canvas Sub Menu*/
        $offCanvasNavSubMenu.parent().prepend('<div class="offcanvas-menu-expand"></div>');

        /*Category Sub Menu Toggle*/
        $offCanvasNav.on('click', 'li a, .offcanvas-menu-expand', function (e) {
            var $this = $(this);
            if ($this.attr('href') === '#' || $this.hasClass('offcanvas-menu-expand')) {
                e.preventDefault();
                if ($this.siblings('ul:visible').length) {
                    $this.parent('li').removeClass('active');
                    $this.siblings('ul').slideUp();
                    $this.parent('li').find('li').removeClass('active');
                    $this.parent('li').find('ul:visible').slideUp();
                } else {
                    $this.parent('li').addClass('active');
                    $this.closest('li').siblings('li').removeClass('active').find('li').removeClass('active');
                    $this.closest('li').siblings('li').find('ul:visible').slideUp();
                    $this.siblings('ul').slideDown();
                }
            }
        });
    }
    mobileOffCanvasMenu();


    //wow js active
    new WOW().init();

    //Sticky Header
    $(window).on('scroll', function () {
        var scroll = $(window).scrollTop();
        if (scroll < 245) {
            $('#sticky-header-with-topbar').removeClass("scroll-header");
        } else {
            $('#sticky-header-with-topbar').addClass("scroll-header");
        }
    });

    // Slider Activation
    $(".slider-active").owlCarousel({
        loop: true,
        margin: 0,
        nav: true,
        autoplay: false,
        navText: ['<i class="zmdi zmdi-chevron-left"></i>', '<i class="zmdi zmdi-chevron-right"></i>'],
        autoplayTimeout: 10000,
        items: 1,
        dots: false,
        lazyLoad: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 1
            },
            800: {
                items: 1
            },
            1920: {
                items: 1
            }
        }
    });
    //Brand carousel Slider
    $('.our__brand_list').owlCarousel({
        loop: true,
        nav: false,
        autoplay: true,
        items: 4,
        responsiveClass: true,
        responsive: {
            0: {
                items: 1,
            },
            575: {
                items: 2,
            },
            767: {
                items: 2,
            },
            992: {
                items: 3,
            },
            1199: {
                items: 4,
            }
        }
    });

    //Services carousel Slider

    $('.services__list').owlCarousel({
        loop: true,
        nav: false,
        autoplay: false,
        items: 3,
        margin: 30,
        responsiveClass: true,
        responsive: {
            0: {
                items: 1,
            },
            767: {
                items: 2,
            },
            992: {
                items: 3,
            }
        }
    });

    //magnificPopup active
    $('.play_video a,.play_button_inner > a').magnificPopup({
        disableOn: 0,
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: true,
        fixedContentPos: false
    });


    //Datepicker
    $('#datepicker,#doctor_calender').datepicker();


    //NiceSelect
    $('.doctor_select_inner select,.input_mobile_number select').niceSelect();

    //Blog Masonry activation
    $('.blog-masonry').imagesLoaded(function () {
        var $grid = $('.blog-masonry').isotope({
            itemSelector: '.grid-item',
            percentPosition: true,
            masonry: {
                columnWidth: '.grid-item',
            }
        });
    });

    //ScrollUp
    $.scrollUp({
        scrollText: '<i class="zmdi zmdi-chevron-up"></i>',
        easingType: 'linear',
        scrollSpeed: 900,
        animation: 'fade'
    });

})(jQuery);