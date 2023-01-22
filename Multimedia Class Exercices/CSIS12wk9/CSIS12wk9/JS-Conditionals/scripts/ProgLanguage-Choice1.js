//create function to process user input
	//define the variables
let csharp = document.getElementById("csharp");
let java = document.getElementById("java");
let php = document.getElementById("php");
let javascript = document.getElementById("javascript");
let python = document.getElementById("python");

let output = document.getElementById("output");
let btnSubmit = document.getElementById("btnSubmit");

//selected choice
let selectedChoice;


function procProgLangChoice(){
//evalue option selected by the user and display it
//use the checked property of the input
if (csharp.checked) {
	selectedChoice = csharp.value;
}
else if (java.checked) {
	selectedChoice = java.value;
}
else if (php.checked) {
	selectedChoice = php.value;
}
else if (javascript.checked) {
	selectedChoice = javascript.value;
}
else if (python.checked) {
	selectedChoice = python.value;
}

else{
	//remind user to make a Selection
	//use alert dialog
	alert("Please first make a selection!");
}	
//display selected choice
output.innerHTML = 	selectedChoice;
}

//call the Function when the button is clicked
btnSubmit.onclick = function(){procProgLangChoice()}
