//Input Validation JS Script

//reference form inputs
let startMiles = document.getElementsByTagName("input")[0];
let endMiles = document.getElementsByTagName("input")[1];
let galsUsed = document.getElementsByTagName("input")[2];
let mpg = document.getElementsByTagName("input")[3];
let btnSubmit = document.getElementsByTagName("input")[5];

//ref error display para
let errPara = document.getElementById("err");

//define function to validate inputs
function validateInputs(){
	//provide customized error messages
	//check that the startin0g mileage input is not empty
	//if empty report Error
	if(startMiles.value==""){
		throw "Starting mileage input is empty. please enter a value."
	}
	//check that it is a numeric value using isNaN() function
	if (isNaN(startMiles.value)) {
		throw "Invalid input for starting mileage. please enter a numeric value."
	}
	
	//check that the ending mileage input is not empty
	//if empty report Error
	if (endMiles.value=="") {
		throw "Ending mileage input is empty. please enter a value."
	}
	//check that it is a numeric value using isNaN() function
	if (isNaN(endMiles.value)) {
		throw "Invalid input for ending mileage. please enter a numeric value."
	}
	
		//check that the gallons used input is not empty
	//if empty report Error
	if (galsUsed.value=="") {
		throw "Gallons used input is empty. please enter a value."
	}
	//check that it is a numeric value using isNaN() function
	if (isNaN(galsUsed.value)) {
		throw "Invalid input gallons used. please enter a numeric value."
	}	
	
}

//define function to compute mileage
function computeMileage(){
	//try{}--catch{} blocks go inside this function
	try{
		//ensure that the inputs are in proper format
		//call validate inputs function
		validateInputs();
		//if inputs are proper format. compute miles per gallon and then display the result
		let milesPerGal = ((endMiles.value)-(startMiles.value))/(galsUsed.value)
		//also clear the error messages display if inputs are in proper format and then display the result
		errPara.innerHTML = "";
		
		//display the result formatted to 2 decimal places
		mpg.value = milesPerGal.toFixed(2);
	} //end of try BlockList
	
	//catch block - catch and report the errors
	//Note: e parameter is the error object with the appropriate error message
	catch(e){
		//display in errPara
		errPara.innerHTML = e;
	}
	//leave out finally{} block: optional
	
	//call function
	btnSubmit.onclick = function() {computeMileage();}
	
	
	
}