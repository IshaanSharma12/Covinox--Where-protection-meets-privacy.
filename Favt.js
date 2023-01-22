// This is the JS file for the Basic Practice 

let Maths= document.getElementById("Math");
let Physic= document.getElementById("Physics");
let ComputeScience= document.getElementById("CompSc");

let submit= document.getElementById("BtnSubmit");
let output= document.getElementById("output");

let selectedvalue=0;

function Favt() {
	
	if (Maths.checked) {
		
		selectedvalue= Maths.value;
	}
	else if ( Physic.checked) {

		selectedvalue= Physic.value;
	}
	
	else if ( ComputeScience.checked) {

		selectedvalue= ComputeScience.value;
	}
	
	else {

		alert("Please select some value");
	}
	
	output.innerHTML=selectedvalue;
}

submit.onclick= function() {Favt();}