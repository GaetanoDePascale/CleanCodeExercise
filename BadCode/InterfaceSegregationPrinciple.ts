// Bad Code
interface Shape {
	draw();
	resize();
	rotate();
	getArea();
	getPerimeter();
}

class Circle implements Shape {
	public draw() {
		// draw code
	}

	public resize() {
		// resize code
	}

	public rotate() {
		// DO NOTHING
	}

	public getArea() {
		// get area code
	}

	public getPerimeter() {
		// perimeter calculation
	}
}