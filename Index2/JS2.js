function disableTextBox() {
	document.getElementById("textbox").disabled = true;
}

function displayDate() {
	let today = new Date();
	let date = today.getFullYear()+'-'+(today.getMonth()+1)+'-'+today.getDate();
	document.getElementById("date").innerHTML = date;
}

displayDate();