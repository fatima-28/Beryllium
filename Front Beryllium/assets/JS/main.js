      $(document).ready(function () {
            $('.slide').slick({
                dots: true,
                arrows: true,
                autoplay: true,
                autoplaySpeed: 4000,
                prevArrow: '<div class="leftarrows"><i class="fa-solid fa-angle-left "></i></div>',
                nextArrow: '<div class="rightarrows"><i class="fa-solid fa-angle-right "></div>'
            })
        });
        

 $(document).ready(function () {
  $('.work-items').slick({
  infinite: true,
   dots: true,
  slidesToShow: 3,
   autoplay: true,
  autoplaySpeed: 2000,
  slidesToScroll: 3
})
 });