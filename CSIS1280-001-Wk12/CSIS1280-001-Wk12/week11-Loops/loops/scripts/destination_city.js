//Destination City JS File

//ref form inputs
let dest_city = document.getElementsByName("dest_city"); //collection of cities
let btnSubmit = document.getElementById("btn");
let city = document.getElementById("city");

//define a Function
function displayDestCity(){
	//chek which option is selected by the user and display it
	//use for loop to check selected option
	//use "checked" property of the radio buttons of the Form
	for (let i=0; i< dest_city.length;i++){
		if(dest_city[i].checked){
			//display it
			city.innerHTML = dest_city[i].value;
		}
	}
}

//call ther function
btnSubmit.onclick = function() {displayDestCity();}