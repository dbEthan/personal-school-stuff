//testscriptje
let a = 1;
let b = 2;
console.log(a + b);

console.log("Hello, World!");

let today = new Date();
let hourNow = today.getHours();
let greeting;

if (hourNow > 18) {
    greeting = 'Goede Avond!';
}
else if ( hourNow > 12) {
    greeting = 'Goedemiddag!';
}
else if (hourNow = 0) {
    greeting = 'Goedemorgen.';
}
else {
    greeting = 'Welkom.';
}

console.log(greeting);

//voorbeeld van slecht var gebruik
/*function testFunction() {
    var test = 2;           //Dit gaat een error geven omdat var niet buiten de scope van een functie kan.
}
let x = test + 2;
console.log(test)
*/
let firstArray = [];

let secondArray = [1,2,3];

let abc = new Array();

abc = [3, 4, 6, 'hallo'];

let i;
for (i = 0; i < abc.length; i++) {
    console.log(abc[i]);
}

console.log(delete abc[2]);
console.log(typeof abc[2]);


