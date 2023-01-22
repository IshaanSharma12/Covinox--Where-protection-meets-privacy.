//loan prequalifier JS file

//define constants for conditions thresholds
const INCOME = 50000;
const EXP = 4;
const DTIR = 0.35;

//ref form inputs
let salary = document.getElementById("salary");
let workExp = document.getElementById("work_exp");
let curDebt = document.getElementById("cur_loan");
let btnReset = document.getElementById("btnReset");
let btnSubmit = document.getElementById("btnSubmit");
let output = document.getElementById("output");

//variables to hold user inputs
//let usrSalary, usrWorkExp, usrDebt, usrDtir;

//define function
function processLoanApplication(){
	//retrieve user inputs
	let usrSalary = salary.value;
	let usrWorkExp = workExp.value;
	let usrDebt = curDebt.value;
	
	//compute user debt-to-income ratio
	let usrDtir = usrDebt/usrSalary;
	
	//what is the amount the user is prequalified for?
	let amtQualFor = (DTIR - usrDtir)*usrSalary;
	
	//evalue whether the user meets the requirements (nested IF statements)
	//[if (usrSalary>=INCOME && usrWorkExp >=EXP && usrDtir<=DTIR){}]
	if(usrSalary>=INCOME){
		if (usrWorkExp >=EXP) {
			if (usrDtir<=DTIR){
				//display a message for the user
				output.innerHTML = "Congratulations! You qualify for a loan. You are preapproved for a loan of $" +amtQualFor.toFixed(2);
			} //end of innermost if statement
			else{
				//user does not qualify due usrDtir > DTIR
				output.innerHTML = "Sorry! You don't qualify for a loan at the moment because your DTIR of " +usrDtir.toFixed(2) +" is greater than the threshold of " +DTIR;
			}
		}//end of middle if
		else {
			//user doesn't qulaify because work experience is less than 4 years
			output.innerHTML = "Sorry! You don't qualify for a loan at the moment because your work experiece of " +usrWorkExp +" is less than the threshold of " +EXP;
		}
	}//end of out if
	else {
		//user doesn't qualify because income is less than 50K
		output.innerHTML = "Sorry! You don't qualify for a loan at the moment because your income of $" +usrSalary +" is less than the threshold of $" +INCOME;
	}
	
}

//Call the function
btnSubmit.onclick = function() {processLoanApplication();}

