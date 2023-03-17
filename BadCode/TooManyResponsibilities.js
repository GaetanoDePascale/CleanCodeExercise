// Bad Code
function calculateArea(shape, width, height, radius) {
    if (shape === "circle") {
        return Math.PI * radius * radius;
    } else if (shape === "rectangle") {
        return width * height;
    } else if (shape === "triangle") {
        return (width * height) / 2;
    }

    throw new Error('Unknown shape!');
}