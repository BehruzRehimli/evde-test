let maash = [500,700,900,950,1200,1500];
for (let i = 0; i < maash.length; i++) {
    console.log(maash[i] + " atib oldu " + maash[i] *1.2);
    
}
let a =  [
    {
        id: 1,
        ad: "Behruz",
        maash: 900
    },
    {
        id: 2,
        ad: "Faiq",
        maash: 700 
    },
    {
        id : 3,
        ad : "Mubariz",
        maash : 800

    }
]
a.forEach(a => {
    console.log(a.maash);

});


