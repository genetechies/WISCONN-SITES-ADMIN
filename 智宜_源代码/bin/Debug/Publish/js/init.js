/* DROPDOWN MENU */
jQuery(function(){
	jQuery('ul.sf-menu').superfish({
		speed: 200,
		animation:  {opacity:'show',height:'show'}
	});
});


/* FORM VALIDATION 
$(function(){
    $("#contact_form").validate({
	  rules: {
		email: {
		  	required: true,
		  	email: true
		},
		verification: {
      		equalTo: "#string"
    	}
	  },
	  messages: {
		verification: {
			required: "This field is required",
			equalTo: "The verification code was wrong"
		}
	  }
	});
});
*/