//JS for tabbed panel

//define a function to switch "current" class for both tab links and tab content

function addRemoveClass(evt){
	
	//ref active tab (links and content)
	//document.querySelectorAll(".current") === document.getElementsByClassName("current")
	let active_tabs = document.querySelectorAll(".current")
	
	//remove "current" class from active tab links and their content
	//use replace() string method
	for (active_tab of active_tabs){
	active_tab.className = active_tab.className.replace("current","")
	}
	//attach current class to clicked tab_link
	//ref anchor using evt.target property: returns the element that triggered the Event
	let anchor = evt.target
	
	//ref the li because it is the one which has the class (use child.parentElement property)
	let listItem = anchor.parentElement
	
	//add current class to the li
	listItem.className += " current"
	
	//Also ad class "current" to the associated content panel of the clicked tab link
	//extract the last 5 characters of the url string for tab ID
	let tab_id = anchor.href.substring(anchor.href.length-5)
	
	//use id to ref tab content and add "current" class to it
	document.getElementById(tab_id).className += " current"
	
}

//call function
//ref ul container
let ul_container = document.getElementById("ul_tab_nav")

//add event listener to it
ul_container.addEventListener("click",addRemoveClass,false)