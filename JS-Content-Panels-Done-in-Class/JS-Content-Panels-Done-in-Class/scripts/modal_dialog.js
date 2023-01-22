//JS File for modal dialog
//when the button is clicked, show the contents of the modal dialog

//ref button
let btn = document.getElementById("myBtn")

//ref the modal dialogArguments
let modal = document.getElementById("myModal")

//ref span
let para = document.getElementsByTagName("p")

//when the button is clicked, show the modal dialog 
btn.onclick = function(){
	modal.style.display = "block";
}

//close the dialog when someone clicks on the span
para[0].onclick = function(){
	modal.style.display = "none";
}

