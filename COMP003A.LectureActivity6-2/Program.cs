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
		static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}