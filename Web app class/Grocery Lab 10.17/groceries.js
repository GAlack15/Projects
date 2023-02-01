/* Complete the JavaScript functions below so the list is restored when the page is reloaded:

loadList() should load a grocery list from localStorage and return an array containing each item. Assume the list is stored as a single comma-delimited string. Ex: The list stored as "orange juice,milk,cereal" is returned as the array ["orange juice", "milk", "cereal"]. An empty array should be returned if localStorage does not contain a grocery list.

saveList() should save the given groceryList array to localStorage as a single comma-delimited string. Ex: The array ["orange juice", "milk", "cereal"] should be saved as the string "orange juice,milk,cereal".

clearList() should remove the grocery list from localStorage.

All three functions should use the localStorage item called "list".

 */


let groceryList = [];

// Wait until DOM is loaded
window.addEventListener("DOMContentLoaded", function() {
   document.querySelector("#addBtn").addEventListener("click", addBtnClick);
   document.querySelector("#clearBtn").addEventListener("click", clearBtnClick);

   // Load the grocery list from localStorage
    groceryList = loadList();
  
   if (groceryList.length > 0) {
      // Display list
      for (let item of groceryList) {
         showItem(item);
      } 
   }
   else {
      // No list to display
      enableClearButton(false);
   }     
});

// Enable or disable the Clear button
function enableClearButton(enabled) {
   document.querySelector("#clearBtn").disabled = !enabled;
}

// Show item at end of the ordered list
function showItem(item) {
   let list = document.querySelector("ol");
   list.innerHTML += `<li>${item}</li>`;     
}

// Add item to grocery list
function addBtnClick() {
   let itemTextInput = document.querySelector("#item");
   let item = itemTextInput.value.trim();
   if (item.length > 0) {
      enableClearButton(true);
      showItem(item);
      groceryList.push(item);

      // Save groceryList to localStorage
      saveList(groceryList);
   }

   // Clear input
   itemTextInput.value = '';
}

// Clear the list
function clearBtnClick() {
   enableClearButton(false);
   groceryList = [];
   let list = document.querySelector("ol");
   list.innerHTML = "";

   // Remove the grocery list from localStorage
   clearList();
}

// Complete the functions below
/* loadList() should load a grocery list from localStorage and return an array containing each item. Assume the list is stored as a single comma-delimited string. Ex: The list stored as "orange juice,milk,cereal" is returned as the array ["orange juice", "milk", "cereal"]. An empty array should be returned if localStorage does not contain a grocery list. */
function loadList() {
	let potatoes = [];
	
	let stuff = localStorage.getItem("list");
	if(stuff != null){
		potatoes = stuff.split(",");
	}
	
	return potatoes;
}
/* saveList() should save the given groceryList array to localStorage as a single comma-delimited string. Ex: The array ["orange juice", "milk", "cereal"] should be saved as the string "orange juice,milk,cereal". */
function saveList(groceryList) {
	let something = groceryList.join(",");
	
	localStorage.setItem("list", something);
}

function clearList() {
   localStorage.removeItem("list");
}