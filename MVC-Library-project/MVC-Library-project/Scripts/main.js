$(document).ready (function(){
    $(".button-collapse").sideNav();
    $('.parallax').parallax();
    $('.dropdown-button').dropdown({
      constrainWidth: false, // Does not change width of dropdown to that of the activator
      // Activate on hover
      gutter: 0, // Spacing from edge
      belowOrigin: true, // Displays dropdown below the button
      alignment: 'left', // Displays dropdown with edge aligned to the left of button
      stopPropagation: true // Stops event propagation
    }
  );

  $('.modal-trigger').leanModal(); //modal version 0.97.5

});
