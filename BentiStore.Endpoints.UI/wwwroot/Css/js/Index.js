var $logo = $('#logo-scroll');
$(document).scroll(function() {
    $logo.css({display: $(this).scrollTop()>100 ? "block":"none"});
});

var win = window,
    docEl = document.documentElement,
    $logo = document.getElementById('logo-scroll');

win.onscroll = function(){
   var sTop = (this.pageYOffset || docEl.scrollTop)  - (docEl.clientTop || 0);
   $logo.style.display =  sTop > 100 ? "block":"none" ;
};