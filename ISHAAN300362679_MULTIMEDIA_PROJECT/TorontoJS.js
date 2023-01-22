// JS file for the Toronto
//ISHAAN SHARMA
//300362679

let it= document.getElementById("IT");
let sr= document.getElementById("Standards");
let we= document.getElementById("Weather");
let sub= document.getElementById("BUTT1");

let op= document.getElementById("output");

let selectedchoice=0;


function choose() {
	
	if (it.checked) {

		selectedchoice="RIGHT! TECH INDUSTRY IS TEH REASON";
		
	}
	
	else if ( sr.checked) {

		selectedchoice="Wrong";
	}
	
	else if (we.checked) {

		selectedchoice="Wrong";
	}
	
	
	
	op.innerHTML=selectedchoice;
	
}

sub.onclick= function() {choose();}