//pick 3 unique quotes at random to display
//we do..while to ensure that we pick 3 unique quotes from the collection

//define a function that will randomly pick 3 quotes based on their indices or subscripts

function genRandInt(min,max){
	//use Math.floor() and Math.random() predefined JS Methods
	//Math.random() method generates a random value (folating point) between 0 and 1
	//use Math.floor() to convert it to the largest integer less than the number and then return it
	return Math.floor(Math.random*(max-min));
	
}