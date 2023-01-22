// JS file for Montreal 
//ISHAAN SHARMA
//300362679

let fr= document.getElementById("french");
let en= document.getElementById("English");
let both= document.getElementById("Both");

let submit= document.getElementById("sub");

let op=document.getElementById("output");

let selectedchoice=0;

function choose() {
	
	if (fr.checked) {

		selectedchoice="RIGHT!!! BONJOUR "
		
	}
	
	else if (en.checked) {

		selectedchoice="WRONG";
		
	}
	
	else if (both.checked) {

		selectedchoice= "Wrong";
	}
	
	
	op.innerHTML=selectedchoice;
	
	
}


submit.onclick= function() {choose();}