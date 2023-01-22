//pick 3 unique quotes at random to display
//we do..while to ensure that we pick 3 unique quotes from the collection

//define the Array
var arrMotivation = new Array("The Way Get Started Is To Quit Talking And Begin Doing. - Walt Disney",
"The Pessimist Sees Difficulty In Every Opportunity. The Optimist Sees Opportunity In Every Difficulty.- Winston Churchill",
"Don't Let Yesterday Take Up Too Much Of Today. - Will Rogers",
"You Learn More From Failure Than From Success. Don't Let It Stop You. Failure Builds Character. - Unknown",
"It's Not Whether You Get Knocked Down, It's Whether You Get Up. - Vince Lombardi",
"If You Are Working On Something That You Really Care About, You Don't Have To Be Pushed. The Vision Pulls You. - Steve Jobs",
"People Who Are Crazy Enough To Think They Can Change The World, Are The Ones Who Do. - Rob Siltanen",
"Failure Will Never Overtake Me If My Determination To Succeed Is Strong Enough. - Og Mandino",
"Entrepreneurs Are Great At Dealing With Uncertainty And Also Very Good At Minimizing Risk. That's The Classic Entrepreneur. - Mohnish Pabrai",
"We May Encounter Many Defeats But We Must Not Be Defeated. - Maya Angelou");


//define a function that will randomly pick 3 quotes based on their indices or subscripts

function genRandInt(min,max){
	//use Math.floor() and Math.random() predefined JS Methods
	//Math.random() method generates a random value (folating point) between 0 and 1
	//use Math.floor() to convert it to the largest integer less than the number and then return it
	return Math.floor(Math.random()*(max-min)+min);
	
}

//define to display quotes
function displayQuotes(){
	//define min and max variables
	let min=0;
	let max = arrMotivation.length;
	
	//use do...while loop to generate 3 subscripts
	//define subscript variables
	let indx1=0, indx2=0, indx3=0;
	do {
		indx1  = genRandInt(min,max);
		indx2  = genRandInt(min,max);
		indx3  = genRandInt(min,max);
	}
	while (indx1==indx2||indx1==indx3||indx2==indx3);
	
	//ref display para
	let mQuotes = document.getElementById("mQuotes");
	
	//display the 3 randomly generated quotes from the Array
	mQuotes.innerHTML = arrMotivation[indx1] +"<br><br>";
	mQuotes.innerHTML += arrMotivation[indx2] +"<br><br>";
	mQuotes.innerHTML += arrMotivation[indx3] +"<br><br>";
}

//call Function. use setInterval() to run the function after every 5 seconds
//note: setInterval() is a higher-order function that takes another function as a parameter
setInterval(displayQuotes,5000);
