$(document).ready (function(){
    $('.sidenav').sidenav();
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
   $('.modal-trigger').leanModal(); //ฟวยยยย คำสั่งชาติไหนแล้ว ชาวบ้านเขาไป 1.0 รีบอัพเดทได้ล้าววว ถถถถถถ

});
