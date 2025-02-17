namespace COMP003A.LectureActivity6_2
{
    internal class Program
    {
		/// <summary>
		/// Demonstrates method overloading for different shape calculations.
		/// </summary>
		class ShapeCalculator
		{
			/// <summary>
			/// Calculates the area of a circle.
			/// </summary>
			/// <param name="radius"></param>
			/// <returns></returns>
			public double CalculateArea(double radius)
			{
				return Math.PI * radius * radius;
			}

			/// <summary>
			/// Calculates the area of a rectangle.
			/// </summary>
			/// <param name="length"></param>
			/// <param name="width"></param>
			/// <returns></returns>
			public double CalculateArea(double length, double width)
			{
				return length * width;
			}

			/// <summary>
			/// Calculates the area of a triangle.
			/// </summary>
			/// <param name="baseLength"></param>
			/// <param name="height"></param>
			/// <param name="isTriangle"></param>
			/// <returns></returns>
			public double CalculateArea(double baseLength, double height, bool isTriangle)
			{
				return 0.5 * baseLength * height;
			}
		}
		/// <summary>
		/// Represents a base class for geometric shapes.
		/// </summary>
		class Shape
		{
			/// <summary>
			/// Displays the area of a shape.
			/// </summary>
			public virtual void DisplayArea()
			{
				Console.WriteLine("Calculating area of a shape.");
			}
		}
		/// <summary>
		/// Represents a circle with a specific area calculation.
		/// </summary>
		class Circle : Shape
		{
			// Auto-implemented property for the radius of the circle.
			public double Radius { get; set; }

			/// <summary>
			/// Constructor for the Circle class.
			/// </summary>
			/// <param name="radius"></param>
			public Circle(double radius)
			{
				Radius = radius;
			}

			/// <summary>
			/// Displays the area of a circle.
			/// </summary>
			public override void DisplayArea()
			{
				Console.WriteLine($"Circle Area: {Math.PI * Radius * Radius}");
			}
		}
		/// <summary>
		/// Represents a rectangle with a specific area calculation.
		/// </summary>
		class Rectangle : Shape
		{
			// Auto-implemented properties for the length and width of the rectangle.
			public double Length { get; set; }
			public double Width { get; set; }

			/// <summary>
			/// Constructor for the Rectangle class.
			/// </summary>
			/// <param name="length"></param>
			/// <param name="width"></param>
			public Rectangle(double length, double width)
			{
				Length = length;
				Width = width;
			}

			/// <summary>
			/// Displays the area of a rectangle.
			/// </summary>
			public override void DisplayArea()
			{
				Console.WriteLine($"Rectangle Area: {Length * Width}");
			}
		}
		static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}