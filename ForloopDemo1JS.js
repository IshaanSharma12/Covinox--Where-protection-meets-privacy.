// JS file for the Loop Demo 

let desttt= document.getElementsByName("Destcity");
let submit= document.getElementById("subss");

let Citty= document.getElementById("Favvt");


function Choose(){
	
	for (let i=0; i<desttt.length; i++){
		
		if (desttt[i].checked) {

			Citty.innerHTML=desttt[i].value;
		}
	}
	
}

// Calling the function 

submit.onclick= function() {Choose();}