//JS lunch order processing Script

//goal: compute and display lunch order cost based on user selections

//ref lunch items
let chicken = document.getElementById("chicken");
let halibut = document.getElementById("halibut");
let salmon = document.getElementById("salmon");
let salad = document.getElementById("salad");

//lunch cost
let lunchCost =0;

//reference buttons
let btnReset = document.getElementById("btnReset");
let btnSubmit = document.getElementById("btnSubmit");

//ref output para
let output = document.getElementById("output");

//define function
function processLunchOrder(){
	//evaluate selected lunch option and add its cost to lunch order cost
	/*use "checked" property of form input to evaluate whether it is selected
	and the "value" property to retrieve the associated price of the lunch item
	*/
	//add price to lunch cost running total
	//lunchCost = lunchCost + itemPrice; lunchCost += itemPrice
	//explicit convert the values retrived to numeric form using parseFloat()
	(chicken.checked)?lunchCost += parseFloat(chicken.value):lunchCost+=0;
		
	//add price to lunch cost running total
		(halibut.checked)?lunchCost += parseFloat(halibut.value):lunchCost+=0;
	
	//add price to lunch cost running total
		(salmon.checked)?lunchCost += (salmon.value)*1.0:lunchCost+=0;

		(salad.checked)?lunchCost += parseFloat(salad.value):lunchCost+=0;
	
	//display lunch cost with dollar sign and rounded to 2 decimal places
	output.innerHTML = "The total cost of your lunch order is: $" +lunchCost.toFixed(2)
	
}

//call Function
btnSubmit.onclick = function() {processLunchOrder();}

//function to clear outputs
function clearOutput(){
	//set the content of the display para to an empty string
	output.innerHTML = "";
}

//call Function
btnReset.addEventListener("click",clearOutput);
