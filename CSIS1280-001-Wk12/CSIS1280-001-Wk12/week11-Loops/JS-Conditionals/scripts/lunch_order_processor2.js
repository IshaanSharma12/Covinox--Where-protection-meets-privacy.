//JS lunch order processing Script

//goal: compute and display lunch order cost based on user selections

//ref lunch items
/*
let chicken = document.getElementById("chicken");
let halibut = document.getElementById("halibut");
let salmon = document.getElementById("salmon");
let salad = document.getElementById("salad");*/
let lunchItems = document.getElementsByName("lunchItems"); //collection

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
	/*
	if(chicken.checked){
		//add price to lunch cost running total
		//lunchCost = lunchCost + itemPrice; lunchCost += itemPrice
		//explicit convert the values retrived to numeric form using parseFloat()
		lunchCost += parseFloat(chicken.value);
	}
	if (halibut.checked) {
		//add price to lunch cost running total
		//lunchCost = lunchCost + itemPrice; lunchCost += itemPrice
		lunchCost += parseFloat(halibut.value);
	}
	if (salmon.checked) {
		//add price to lunch cost running total
		//lunchCost = lunchCost + itemPrice; lunchCost += itemPrice
		lunchCost += (salmon.value)*1.0;
	}
	if (salad.checked) {
		//add price to lunch cost running total
		//lunchCost = lunchCost + itemPrice; lunchCost += itemPrice
		lunchCost += parseFloat(salad.value);
	}
	*/
	//evaluate user selections using for loop
	for (let j=0; j<lunchItems.length; j++) {
		if (lunchItems[j].checked){
			//add its cost to total cost
			lunchCost += parseFloat(lunchItems[j].value);
		}
	}
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
