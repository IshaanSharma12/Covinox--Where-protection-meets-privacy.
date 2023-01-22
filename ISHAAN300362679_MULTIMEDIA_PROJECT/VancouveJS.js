// JS file for the Vancouver. 
//ISHAAN SHARMA
//300362679
let beauty= document.getElementById("vancityradio");
let cloud= document.getElementById("vancityradio2");
let seattle= document.getElementById("vancityradio3");

let sub= document.getElementById("complete");

let op= document.getElementById("bestt");

let selectedchoice=0;

function choosee(){
	
	if (beauty.checked) {

		selectedchoice= "Wrong";
		
	}
	
	else if (cloud.checked) {

		selectedchoice= "Right";
		
	}
	
	else if ( seattle.checked) {

		selectedchoice= "wrong";
	}
	
	
	op.innerHTML=selectedchoice;
	
}

sub.onclick= function() {choosee();}