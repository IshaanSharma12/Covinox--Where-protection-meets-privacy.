// JS file for the Lunch order Processing


let subbutt= document.getElementById("buttsub");

let OP= document.getElementById("output");

let chick = document.getElementById("FC");
let hali= document.getElementById("HB");
let salm= document.getElementById("SL");
let sala= document.getElementById("SAL");


let lunchc=0;

function calclunch(){
	
	(chick.checked)?lunchc:parseFloat(chick.value):lunchc+=0;
	(hali.checked)?lunchc:parseFloat(hali.value):lunchc+=0;
	(salm.checked)?lunchc:parseFloat(salm.value):lunchc+=0;
	(sala.checked)?lunchc:parseFloat(sala.value):lunchc+=0;
	
	OP.innerHTML= "total bill is" + lunchc
}

subbutt.onclick= function() {calclunch();}