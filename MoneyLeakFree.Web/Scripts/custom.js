/* Share panel */

$(document).ready(function () {

    $('.matter').slideToggle('1000', "swing");

	$(".open").click(function(e){
		e.preventDefault();
		$(".sharepanel").slideToggle('1000',"swing");	
	});	
  
  /* Sidebar */
  
	$(".matopen").click(function(e){
	    e.preventDefault();

	    var currentOpenedSlideWasClikedToClose = $(this).next('.matter').hasClass("matterActive");

	    if (currentOpenedSlideWasClikedToClose) {
	        // Closing current opened slide and removing class
	        $(".matterActive").slideToggle('1000', "swing");
	        $(".matterActive").removeClass("matterActive");
	    }
	    else {
	        // Closing current opened slide and removing class
	        $(".matterActive").slideToggle('1000', "swing");
	        $(".matterActive").removeClass("matterActive");

	        // Adding class to requested slide and opening it.
	        $(this).next('.matter').addClass("matterActive");
	        $(".matterActive").slideToggle('1000', "swing");
	    }
	});
});

/* Isotype */

// cache container
var $container = $('#portfolio,#portfolio-big');

// filter items when filter link is clicked
$('#filters a').click(function(){
	var selector = $(this).attr('data-filter');
	$container.isotope({ filter: selector });
	return false;
});               

/* Navigation (Select box) */

// Create the dropdown base
$("<select />").appendTo(".navis");

// Create default option "Go to..."
$("<option />", {
	"selected": "selected",
	"value"   : "",
	"text"    : "Menu"
}).appendTo(".navis select");

// Populate dropdown with menu items
$(".navi a").each(function() {
	var el = $(this);
	$("<option />", {
		"value"   : el.attr("href"),
		"text"    : el.text()
	}).appendTo(".navis select");
});

$(".navis select").change(function() {
	window.location = $(this).find("option:selected").val();
});

/* Moving sidebar below in small screens. */

$('.sidey').clone().appendTo('.mobily');


/* Flex Slider */

$(window).load(function(){
  $('.flexslider').flexslider({
	easing: "easeInOutCubic",
	controlNav: false,
	start: function(slider){
	  $('body').removeClass('loading');
	}
  });
});
	

/* *************************************** */ 
/* Scroll to Top */
/* *************************************** */  
		
$(document).ready(function() {
	$(".totop").hide();
	
	$(window).scroll(function(){
		if ($(this).scrollTop() > 300) {
			$('.totop').fadeIn();
		} else {
			$('.totop').fadeOut();
		}
	});
	$(".totop a").click(function(e) {
		e.preventDefault();
		$("html, body").animate({ scrollTop: 0 }, "slow");
		return false;
	});
		
});
/* *************************************** */
    
