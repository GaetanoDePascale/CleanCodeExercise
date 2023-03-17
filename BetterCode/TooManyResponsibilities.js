// Better Code
const getCircleArea = (shape) => Math.PI * shape.radius * shape.radius;
const getRectangleArea = (shape) => shape.width * shape.height;
const getTriangleArea = (shape) => (shape.width * shape.height) / 2;

const areaCalculationMethos = {
    circle: getCircleArea,
    rectangle: getRectangleArea,
    triangle: getTriangleArea,
};

function calculateArea(shape, width, height, radius) {
    const shapeObject = { width, height, radius };
    const calculateAreaMethod = areaCalculationMethos[shapeName];

    try {
        return calculateAreaMethod(shapeObject);
    } catch {
        throw new Error('Unknown shape!');
    }
}
