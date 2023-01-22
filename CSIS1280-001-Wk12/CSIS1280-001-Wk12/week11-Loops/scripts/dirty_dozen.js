//display the elements of the "dirty dozen"

//define the array
const dirtyDozen = ["Strawberies", "Spinach", "Kale, collard and mustard greens", "Nectarines", "Apples", "Grapes", "Bell and hot peppers", "Cherries", "Peaches", "Pears", "Celery", "Tomatoes"];

//create for...of loop to display the elements of the Array
//each element is extracted and temporarily stored in the iteration variable (e.g., fruitVeg is the iteration variable)

//ref display para
let output = document.getElementsByTagName('p')[0];
for (let fruitVeg of dirtyDozen){
	//display values one per line
	output.innerHTML += `${fruitVeg} <br><br>`;
}

//ref display para (with loop control - break statement)
let output1 = document.getElementsByTagName('p')[1];
for (let fruitVeg1 of dirtyDozen) {
	//display values one per line
	if (fruitVeg1=="Apples")
		break;
	output1.innerHTML += `${fruitVeg1} <br><br>`;
	
}

//ref display para (with loop control - continue statement)
let output2 = document.getElementsByTagName('p')[2];
for (let fruitVeg2 of dirtyDozen) {
	//display values one per line
	if (fruitVeg2=="Cherries" ||fruitVeg2=="Peaches")
		continue;
	output2.innerHTML += `${fruitVeg2} <br><br>`;
}

//ref display para (with loop control - continue statement)
let output3 = document.getElementsByTagName('p')[3];
//use for loop
for (let num=1;num<=100;num++){
	//subcondition for continue statement
	if (num>=40 && num<=60)
		continue;
	if (num%6==0) {
		output3.innerHTML += `${num} <br>`;
	}
}


