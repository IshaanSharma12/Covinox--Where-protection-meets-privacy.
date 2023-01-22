// js file for seattle
//ISHAAN SHARMA
//300362679

let cali= document.getElementById("radiobutton1");
let oreg= document.getElementById("radiobutton2");
let wash= document.getElementById("radiobutton3");
let mont= document.getElementById("radiobutton4");

let op= document.getElementById("output");
let submit= document.getElementById("subbs");

let selectedchoice=0;

function choose() {
	
	if (cali.checked) {

		selectedchoice= "Wrong! This is not Bay Area ROFL";
		
	}
	
	else if (oreg.checked) {


		selectedchoice="Wrong";
		
	}
	
	else if (wash.checked) {


		selectedchoice="WOW! YOU ARE QUITE TECHY! THIS IS RIGHT";
		
	}
	else if ( mont.checked) {

		selectedchoice="Wrong";
		
	}
	
	op.innerHTML= selectedchoice;
	
	}
	
	submit.onclick= function() {choose();}