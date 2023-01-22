// JS file for the Feedback
//ISHAAN SHARMA
//300362679

let name= document.getElementById("tb1");
let pno= document.getElementById("tb2");
let dep= document.getElementById("rb1");
let inte= document.getElementById("rb2");
let triv= document.getElementById("rb3");
let all = document.getElementById("rb4");

let sub= document.getElementById("bt1");
let output= document.getElementById("Helo");

let selectedchoice=0;


function choose(){
	
	if (dep.checkded) {

		selectedchoice= dep.value + "Thanks";
		
	}
	
	else if (inte.checked) {

		selectedchoice=inte.value + "We are glad you liked our content" ;
		
	}
	
	else if ( triv.checked) {

		selectedchoice=triv.value + "Thanks Trivia Questions were idea of Ishaan, who is our founder" ;
	}
	
	else if ( all.checked) {

		selectedchoice=all.value + "Thanks, we couldn't we more happier :))))"
	}
	
	output.innerHTML=selectedchoice;
	
}

sub.onclick= function() {choose();}