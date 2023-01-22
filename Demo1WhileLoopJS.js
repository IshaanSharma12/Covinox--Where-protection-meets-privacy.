// While loop demo 1 js 

lets ops= document.getElementById("Output");

let sec=50;

while (sec>0) {

	ops.innerHTML+=sec + "Left until Diwali";
	
	sec--;
}

ops.style.color="red";
ops.style.fontWeight="bold";
ops.style.display="Happy Diwali";