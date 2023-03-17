// Better Code
interface Drawable {
	draw();
}
interface Resizable {
	resize();
}
interface Rotatable {
	rotate();
}
interface Measurable {
	getArea();
	getPerimeter();
}

class Circle implements Drawable, Resizable, Measurable {
	public draw() {
		// draw code
	}

	public resize() {
		// resize code
	}

	public getArea() {
		// get area code
	}

	public getPerimeter() {
		// perimeter calculation
	}
}