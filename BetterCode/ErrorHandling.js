// Better Code
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

    throw new Error(`symbol not found for ${name}`);
}