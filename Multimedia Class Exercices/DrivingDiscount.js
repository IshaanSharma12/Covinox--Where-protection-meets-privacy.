//JS File for the driving discount// 

let submit= document.getElementById("BttnSubmit");

function drivingdiscountprocess(){
	
let age= document.getElementById("agetb").value;
let defdrivey= document.getElementById("ddcy");
let defdriven= document.getElementById("ddcn");
let accy= document.getElementById("accy");
let accn= document.getElementById("accno");

if (age>18 || defdrivey.checked || accn.checked) {

	alert("Congrats you qualify for the driving discount");
}
	
	
else {

	alert("Sorry you dont qualify at the moment, we recommend you taking our on location driving course");
	
}
	
}

submit.onclick= function() {drivingdiscountprocess();}