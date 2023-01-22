// Js file for the facourite restaurant selector //

let Hash= document.getElementById("HB");
let fish= document.getElementById("Fish");
let poutine= document.getElementById("Pout");
let button= document.getElementById("Submit");
let Output= document.getElementById("output");
let Txt= document.getElementById("TB");

let selectedchoice=0;


function choose() {
	
	if (Hash.checked) {

		selectedchoice= Hash.value;
		
	}
	
 else if ( fish.checked) {

	 selectedchoice= fish.value;
 	
 }
	
	else if ( poutine.checked) {

		selectedchoice= poutine.value;
		
	}
	
 Txt.value=selectedchoice;
 
}


button.onclick= function() {choose();}