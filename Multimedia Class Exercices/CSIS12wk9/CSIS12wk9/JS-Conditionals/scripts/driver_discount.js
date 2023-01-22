//Driver discount JS file

//define function
function processDriverDiscount(){
//ref form inputs and retrive their values and assign to variables
let usrAge = document.getElementById("age").value;
let defDriveYes = document.getElementById("def_yes")
let defDriveNo = document.getElementById("def_no")
let accYes = document.getElementById("acc_yes")
let accNo = document.getElementById("acc_no")

//evalue user options - if any of the conditions is met, the driver qualifies for a discount
if(usrAge >=21||defDriveYes.checked||accNo.checked){
	//provide feedback to the user using an alert dialog
	alert("Congratulations! You qualify for a driver discount of 10%.");
	
}
else {
	alert("Sorry, none of the conditions is met. So you don't qualify for a driver discount at the moment. We recommend taking defensive driving course.");
}
}

//call function
document.getElementById("btnSubmit").onclick = function() {processDriverDiscount();}