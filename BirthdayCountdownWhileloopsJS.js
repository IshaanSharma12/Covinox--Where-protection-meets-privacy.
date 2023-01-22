// JS file for the birthday countdown 

let disp= document.getElementById("DISPP");

let secs=60;


	
	while (secs>0) {

		disp.innerHTML+=secs;
		secs--;
	}
	disp.style.color="red";
	disp.innerHTML+="Happy Birthday Dear";
	


