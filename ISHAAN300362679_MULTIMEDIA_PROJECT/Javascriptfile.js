// JS clip for the TechMerica.
//ISHAAN SHARMA
//300362679 

let student= document.getElementById("Student");
let jobseeker= document.getElementById("JobSeeker");
let employeer= document.getElementById("Employeer");
let investor= document.getElementById("Investor");
let Submit= document.getElementById("bttnSubmit");
let Output= document.getElementById("output");
let selectedchoice=0;

function choose(){
	
	if (student.checked) {

		selectedchoice= student.value;
	
	}
	
	else if ( jobseeker.checked) {

		selectedchoice= jobseeker.value;
		
	}
	
	else if ( employeer.checked) {

		selectedchoice= employeer.value;
	}
	
	else if ( investor.checked) {

		selectedchoice= investor.value;
		
	}
	
	Output.innerHTML= "Dear" + selectedchoice + "Come on lets dive further" ;
	
	
	}
	
	Submit.onclick= function() {choose();}