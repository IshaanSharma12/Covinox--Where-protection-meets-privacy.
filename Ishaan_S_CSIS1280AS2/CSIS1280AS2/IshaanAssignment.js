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

let error= document.getElementById("err");

function Checkforgrpmemberinput(){
	
	if (fName.value=="") {

		throw "Name cannot be empty please try again";
	}
	
	if (lname.value=="") {

		throw "Last name cannot be empty please try again";
	}
	
	if (gSize.value=="") {

		throw "Group size needs a mandate value";
	}
	
	if (isNaN(gSize.value)) {
		throw "Group size needs to be integer please re enter";
	}
	
	
}

function Calcgrpdiscount(){
	try{
		
		 Checkforgrpmemberinput();   // Calling the function, created above
		 let disc= 0;
	     error.innerHTML= "";	 
		 
		 if (gSize>5 && gSize<=10) {

			 disc= (pricepp * gSize)*10/100;
		 }
		 
		 else if (gsize>11 && gSize<=24) {

			 disc=(pricepp * gSize)* 20/100;
		 }
		 
		 else if (gSize>25) {

			 disc= (pricepp *gSize) *25/100;
		 }
		 
		 else {

			 alert("The group size cannot be less than zero");
		 }
		 
	finalPrice.value= disc;
	
	}
	
	catch (e) {

		error.innerHTML=e;
		
	}
	
	// Will call it later with the add group member button.
}

function Addgrpmember(){
	
	grp.value= lName+fname;
	// Displaying the last and the first name in grp TextArea
	
}
addMember.onclick= function() {Addgrpmember();}



function Deletegrpmember() {
	
	grp.value="";
	fName.value="";
	lName.value="";
	
}

delMember.onclick= function() {Deletegrpmember();}


function Sortgroupmembers(){     // Creating the function for sorting the group members. 
	
	
	
	grp.sort(fName, lName);
	
}

sortMember.onclick= function() {Sortgroupmembers()}



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
		}
	}
	
}