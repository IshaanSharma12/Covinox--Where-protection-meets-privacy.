// JS file for the Dest Favt HTML

let mt= document.getElementById("mount");
let sea= document.getElementById("sea");
let lnd= document.getElementById("plain");
let dsrt= document.getElementById("desert");
let Output= document.getElementById("output");

let btn= document.getElementById("BtnSubmit");

let selected=0;

function favttt(){
	
	if (mt.checked) {

		selected= mt.value;
		
	}
	
	else if ( sea.checked) {

		selected= sea.value;
		
	}
	
	else if ( lnd.checked) {

		selected= lnd.value;
	}
	
	else if ( dsrt.checked) {
<!---->
		selected= dsrt.value;
	}
	
	Output.innerHTML="thanks" + "\t" + selected;
	
}

btn.onclick= function() {favttt();}