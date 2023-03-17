// Bad Code
const chemicalSymbols = {
    Sodium: "Na",
    Hydrogen: "H",
    Helium: "He",
    Oxigen: "O",
};

function getSymbol(name) {
    const symbol = chemicalSymbols[name];
    if (symbol) {
        return symbol;
    }

    console.log("symbol not found");
    return "not found";
}