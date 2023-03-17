// Better Code
function calculateTotal(items) {
    let total = 0;
    for (const element of items) {
        total += element.price;
    }
    return total;
}
console.log(calculateTotal(itemsInCart));
console.log(calculateTotal(whishList));
