const inputs = document.getElementById('inputs');

function addInput() {
    let input = document.createElement("input");
    input.setAttribute("type", "text");
    input.setAttribute("name", "values");
    input.setAttribute("placeholder", "Enter a value");
    input.classList.add("mb-1");
    input.classList.add("d-block");
    inputs.appendChild(input);
}