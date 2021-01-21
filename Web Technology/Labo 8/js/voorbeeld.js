let price;
let quantity;
let total;

price = 5;
quantity = 14;

total = price * quantity;

console.log(total);

let priceSpan = document.getElementById("priceSpan"); //deze methode zal het element uit de ID() halen en in een variabele steken
priceSpan.textContent = total;                        // .textContent zal de tekst in het element priceSpan veranderen naar de waarde.