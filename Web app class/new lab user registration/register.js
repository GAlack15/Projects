function checkForm() {
   // TODO: Perform input validation 
let password1 = document.getElementById("password").value;
let confirm1 = document.getElementById("passwordConfirm").value;
let errorMessage = "<ul>";
let isErrorOnTheForm = false;
const fullNameElement = document.getElementById("fullName");
const fullEmailAdress = document.getElementById("email");
const regExpression = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,5}$/;
const userPassword =  document.getElementById("password");
const uppercase = (/[A-Z]/.test(userPassword.value));
const numbers = (/[0-9]/.test(userPassword.value));
const lowercase = (/[a-z]/.test(userPassword.value));
const passwordConfirm =  document.getElementById("passwordConfirm");
;
   // Ensure a full name with a length greater than or equal to 1 was provided
// Otherwise, display "Missing full name."
if( fullName.value.length >= 1){
	 //document.getelementById("fullName").remove("error");
	 fullNameElement.classList.remove("error");
	 //console.log(fullName.length);
 }
 else {
	// document.getElementById('formErrorsUl').innerHTML  += "<li id='missing'>Missing full name.</li>"
	errorMessage += "<li>Missing full name.</li>"
	
	isErrorOnTheForm = true;
	//document.getElementById("formErrors").classList.add("hide");
	 fullNameElement.classList.add("error"); 
 }
 
 // Ensure that an email address was provided and that the email address matches the regular expression:
// /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,5}$/
// Otherwise, display "Invalid or missing email address."
if(fullEmailAdress.value.length >= 1 && regExpression.test(fullEmailAdress.value)){
	fullEmailAdress.classList.remove("error");
	//console.log(fullEmailAdress.value);
	
}
else {
	errorMessage += "<li>Invalid or missing email address.</li>"
	isErrorOnTheForm = true;
	fullEmailAdress.classList.add("error");	
}
// Ensure the password has 10 to 20 characters
// Otherwise, display "Password must be between 10 and 20 characters."

if (userPassword.value.length > 9 && userPassword.value.length < 21){
	userPassword.classList.remove("error");
	//console.log(userPassword.value);
	
}
else{
	errorMessage += "<li>Password must be between 10 and 20 characters.</li>"
	isErrorOnTheForm = true;
	userPassword.classList.add("error");	
}
// Ensure the password contains at least one lowercase character (use a regular expression)
// Otherwise, display "Password must contain at least one lowercase character."
if (lowercase){
	userPassword.classList.remove("error");
	//console.log(userPassword.value);
}
else{
	errorMessage += "<li>Password must contain at least one lowercase character.</li>"
	isErrorOnTheForm = true;
	userPassword.classList.add("error");
}

// Ensure the password contains at least one uppercase character (use a regular expression)
// Otherwise, display "Password must contain at least one uppercase character."
if (uppercase){
	userPassword.classList.remove("error");
	//console.log(userPassword.value);
}
else{
	errorMessage += "<li>Password must contain at least one uppercase character.</li>"
	isErrorOnTheForm = true;
	userPassword.classList.add("error");
}
// Ensure the password contains at least one digit (use a regular expression)
// Otherwise, display "Password must contain at least one digit."
if (numbers){
	userPassword.classList.remove("error");
	//console.log(userPassword.value);
}
else{
	errorMessage += "<li>Password must contain at least one digit.</li>"
	isErrorOnTheForm = true;
	userPassword.classList.add("error");
}
// Ensure the password and confirmation password match
// Otherwise, display "Password and confirmation password don't match."
if( userPassword.value == passwordConfirm.value){
	userPassword.classList.remove("error");
	passwordConfirm.classList.remove("error");
	//console.log(userPassword.value);
}

else{
	errorMessage += "<li>Password and confirmation password don't match.</li>"
	isErrorOnTheForm = true;
	userPassword.classList.add("error");
	passwordConfirm.classList.add("error");
}
 // end of all checks
 
 
 errorMessage += "</ul>";
 console.log(errorMessage);
 if(isErrorOnTheForm == true) {
	 
	 document.getElementById('formErrors').innerHTML = errorMessage;
	 document.getElementById('formErrors').classList.remove("hide");
 }
 else {
	  document.getElementById('formErrors').classList.add("hide");
 }
}

document.getElementById("submit").addEventListener("click", function(event) {
   checkForm();
   // Prevent default form action. DO NOT REMOVE THIS LINE
   event.preventDefault();
});
//Complete checkForm() in register.js to verify that the user-provided information is valid.
//If form validation errors exist:
//Display the formErrors <div> by removing the hide class
// Display each of the associated error messages in the formErrors <div> using an unordered list. The error message must be displayed in the order the validation is performed, following the order specified below.
// Add the error class to each <input> element with invalid input
// If no form validation errors exist:
// Hide the formErrors <div> by adding the hide class
// Remove the error class from all test, email, and password <input> elements
// Perform the following form validations in the order provided and display all error messages that apply:


