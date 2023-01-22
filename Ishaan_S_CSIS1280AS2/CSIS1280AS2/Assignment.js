// JavaScript file for the assignment#2

// first of all declairing the constant 

const pricepp= 50;

// creating the reference inputs here
let fName= document.getElementById("firstname");
let lName= document.getElementById("lastname");
let grp= document.getElementById("members");
let gSize= document.getElementById("GroupSize");
let finalPrice= document.getElementById("discRate");
// buttons

let addMember= document.getElementsByClassName("buttons1");
let delMember= document.getElementsByClassName("buttons2");
let sortMember= document.getElementsByClassName("buttons3");

// This is the reference to the error display
let error= document.getElementById("err");

// creating the first function here. 
function Checkforgrpmemberinput() {


	if (fName.value=="" && fName.value==null) {
		document.getElementById("fName").focus();
		throw "First name is empty please enter a value";
	}
	
	
	
	if (lname.value=="" && lName.value==null) {
		document.getElementById("lName").focus();
		throw "Last name is empty please enter a  value";
		
	}
	
}
	// creating the second function here
	
	function checkforgorupsizeinput(){


	
	if (gSize.value=="" && gSize.value==null) {
		document.getElementById("gSize").focus();
		throw "Group size is empty please enter a value";
	}
	
	if (isNaN(gSize.value)) {
		document.getElementById("gSize").focus();
		throw "Group size needs to be integer please re-enter";
	}
	
}

// Creating the third function here. 

function Calcgrpdiscount(){
	// Try and Catch block will go inside this
	
	
	error.innerHTML="";
	try{
		// Calling the first function
		
		Checkforgrpmemberinput();
		
		let grprpp= gSize* pricepp;
		
		if (gSize>5 && gSize<=10) {

			grprpp-=grprpp*0.1;
			
		}
		
		else if (gSize>11 && gSize<=24) {

			grprpp-= grppp*0.2;
			
			}
			
			else if (gSize>25) {

				grprpp-= grprpp*0.25;
				
			}
			
			else {
				alert("The group size cannot be less than zero");
				
			}
	}
	
	finalPrice.value= grprpp;
	
	catch (e) {

		error.innerHTML(e);
	}
	
	 
}


// created the function addgroupmember()
function addgroupmember(){
	try{
		
		let grpmemberfname= document.getElementById("firstname").value;
		let grpmemberlastname= document.getElementById("lastname").value;
		let listofgrp= document.getElementById("members");
		
		Checkforgrpmemberinput();
		Calcgrpdiscount();
		
		let updatedopt= document.createElement('opt');
		updatedopt.setAttribute('value', grpmemberlastname + "  ,  " + grpmemberfname);
		updatedopt.innerHTML= grpmemberlastname + " , " + grpmemberfname;
		listofgrp.appendChild(updatedopt);
		document.getElementById("firstname").value="";
		document.getElementById("lastname").value="";
		
	}
	catch(error){
		
		alert(error)
	}
	}
	
    
	addMember.onclick= function() {addgroupmember();} // calling the function addgroup member.
	
	



// creating the function  deletegroupmember()
function deletegroupmember(){
	let listofgrp= document.getElementById("members");
	if (listofgrp.innerText=="") {
		alert("There are no members to delete");
		
	}
	
	else {

		listofgrp.remove(listofgrp.selectedIndex);
	}

	}
	
	
	delMember.onclick= function() {deletegroupmember();} // I have called the function here. 
	
	
// creating the function to sort the group members

function listofoperations(d){
	
	if (d.target.value=="add person") {

		addgroupmember();
	}
	
	else if (d.target.value=="remove person") {

		deletegroupmember();
		
	}
	
	else if ( d.target.value=="Sort the persons") {

		sortgroupmembers();
	}
	
	
	
}







function sortgroupmembers(){
	let listofgrp= document.getElementById("members");
	if (listofgrp.innerText=="") {

		var ops= [].sice.call(listofgrp.children);
		
		var sort= option.sort((aa, b) => {
			if (a.value< b.value) {

				return -1;
			}
			
			else if ( b.value > a.value) {

				return +1;
			}
			
		}
	}	

	
}
//setTimeout() function for the bee image to come on the screen and get displayed. 

function Flyingbee(){
	
	var FlyingBee= function() {

		var bee= document.getElementById("bee");
		bee.style.position= "absolute";
		bee.style.left= "0px";
		var fly= Function(){ var_ current_left= parseInt(bee.style.left);}
		bee.style.left= current_left_10 + "px";
		if (current_left < window.innerWidth- bee.width)
			) {

			setTimeout(fly, 50); } else {

			var sunflower= document.getElementById("sunflower");
			bee.style.left= sunflower.offsetLeft + "px"; bee.style.top + "px";
			document.getElementById("advice").style
	
}