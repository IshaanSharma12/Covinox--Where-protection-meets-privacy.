// Javascript file for the loan qualifier 

let Submit= document.getElementById("buttsub");

function loanqual(){
	
	let salary= document.getElementById("sal").value;
	let workexx= document.getElementById("workex").value;
	let currentl= document.getElementById("curloan").value;

	if (salary.value=>5000 && workexx.value=>7 && currentl.value<=999) {

		alert("Congrats you qualify for the loan");
	}
	
	else if ( salary.value<=500 && workexx.value<=7 && currentl.value>=999) {

		alert("unfortunately you dont qualify for the loan");
		
	}
	
	else {

		alert("Please cotact our office");
	}
	
	
}

Submit.onclick= function() { loanqual();}