//JS File for Accordion Panel

//function to toggle icons (+ and - icons)
//requires 3 parameters: element and the 2 classes to be toggled
function toggleFaIcons(el,className1,className2){
	el.classList.toggle(className1)
	el.classList.toggle(className2)
}



//ref the container Element
let container = document.getElementsByClassName("container")

//add event listener to container to "listen to" which of the container panels is clicked
//need to work through the container collection using a loop
for (let i=0; i<container.length; i++){
	//add event listener
	container[i].addEventListener('click', function(){
		
		//use the "this" reference to refer to the currently active object and then get its class list and toggle the active class
		this.classList.toggle('active')
		
		//return the children of the current active container Element
		console.log(this.children[0])
		
		//ref div content element
		let div_cont = this.children[0]
		let plus_icon = "fa-plus"
		let minus_icon = "fa-minus"
		
		//call toggleFaIcons() function
		toggleFaIcons(div_cont,plus_icon,minus_icon)
		})
}