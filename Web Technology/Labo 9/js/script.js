let arrAnimals = [
    'Reptielen',
    'Vissen',
    'Vogels',
    'Zoogdieren'
];

let showAnimals = document.getElementById("showAnimals");
showAnimals.textContent = arrAnimals[arrAnimals.length - 1];

const CONDITIONAL = 4;
let lengte = arrAnimals.length;
let tekst;

if (lengte == CONDITIONAL) {
    tekst = "De lijst bevat het juiste aantal elementen.";
}
else {
    tekst = "De lijst bevat niet het juiste aantal elementen.";
}

let elementCount = document.getElementById("elementCount");
elementCount.textContent = tekst;

let land = {
    naam:'Chili',
    hoofdstad:'Santiago',
    taal:'Spaans',
    volkslied:'Chileno!!',
    munteenheid:'Chileense dollar'
}

let landObject = document.getElementById("landObject");
landObject.textContent = `${land.naam} ${land.hoofdstad} ${land.taal} ${land.volkslied} ${land.munteenheid}`; //gebruik backticks voor string interpolatie

arrAnimals[1] = 'amfibieuhn';
arrAnimals[3] = 'dinosaurusseuh';