//while loop JS File

//ref the display paras
let display = document.getElementById("display");
let output = document.getElementById("output");
let output1 = document.getElementById("output1");

//while loop
//initialize counter (counting down from 10 seconds to new year)
let secsLeft = 10;

while (secsLeft>0) {
	display.innerHTML += secsLeft + "seconds left to new year <br>";
	//display.innerHTML += `${secsLeft} seconds left to new year <br>`
	
	//counter update
	secsLeft--;  //secsLeft -=1 //secsLeft = secsLeft - 1
}
//display new year geeting
//modify presentation using JS
display.style.color = "red"; //red font color
display.style.fontWeight = "bold"; //make font weight bold
display.innerHTML += "HAPPY NEW YEAR!";

//display even numbers between 1 and 50
//counter initialization
let number = 2;

while (number <=50){
	//display the number
	output.innerHTML += `The number is ${number} <br>`;
	
	//update the counter
	number +=2;
}

//display even numbers between 1 and 50
//counter initialization
let num = 1;

while (num <=50) {
	//Check whether the number is even, and if so, display the number
	if(num%2==0){
	output1.innerHTML += `The number is ${num} <br>`;
	}
	//update the counter
	num++;
}









