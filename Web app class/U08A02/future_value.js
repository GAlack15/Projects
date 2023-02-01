"use strict";
$(document).ready( () => {

    $("#calculate").click( () => {
        let amount = parseFloat($("#amount").val());
		 let isValid = true;
        if (isNaN(amount) || amount <= 0 || amount > 99) {
            $("#amount").next().text("Must be a valid number greater than 0 and less than or equal to 10,000.");
            isValid = false;
        } else {
            $("#amount").next().text("");
        }
		
        if (isValid) {			
  
			let quarters = Math.floor(amount/25);
				amount = amount - (quarters * 25);
			let dimes = Math.floor(amount / 10);
				amount = amount - (dimes * 10);
			let nickels = Math.floor(amount / 5);
				amount = amount - (nickels * 5);
			let pennies = amount;
			$("#quarters").val(quarters);
			$("#dimes").val(dimes);
			$("#nickels").val(nickels);
			$("#pennies").val(pennies);			
        }
    });

    $(":text").dblclick( () => {
        $("#clear").click();
    })

    $("#amount").focus();
});