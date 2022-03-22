using System;
using System.Linq;

namespace cv7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = new int[] { 1, 3, 5, 7, 9 };

                string[] words = new string[] { "Circle", "Ellipse", "Rectangle", "Square", "Triangle" };

                Circle[] circles = new Circle[] {
                    new Circle(2),
                    new Circle(4),
                    new Circle(8)
                };

                Rectangle[] rectangles = new Rectangle[] {
                    new Rectangle(4, 6),
                    new Rectangle(2, 6),
                    new Rectangle(2, 8)
                };

                Ellipse[] ellipses = new Ellipse[] {
                    new Ellipse(3, 2),
                    new Ellipse(5, 2),
                    new Ellipse(3, 6),
                    new Ellipse(2, 8)
                };

                Triangle[] triangles = new Triangle[] {
                    new Triangle(10, 5, 12),
                    new Triangle(5, 8, 10),
                    new Triangle(3, 4, 6)
                };

                Square[] squares = new Square[] {
                    new Square(2),
                    new Square(3),
                    new Square(4),
                    new Square(5)
                };

                Object2D[] objects2D = new Object2D[] {
                    new Circle(8),
                    new Rectangle(4, 8),
                    new Ellipse(5, 2),
                    new Triangle(3, 4, 6),
                    new Square(2),
                };

                Console.WriteLine("Min integer: {0}", String.Join("\n", Extreme.Min(numbers)));
                Console.WriteLine("Max integer: {0}", String.Join("\n", Extreme.Max(numbers)));
                Console.WriteLine();

                Console.WriteLine("Min string: {0}", String.Join("\n", Extreme.Min(words)));
                Console.WriteLine("Max string: {0}", String.Join("\n", Extreme.Max(words)));
                Console.WriteLine();

                Console.WriteLine("Min {0}", String.Join("\n", Extreme.Min(circles)));
                Console.WriteLine("Max {0}", String.Join("\n", Extreme.Max(circles)));
                Console.WriteLine();

                Console.WriteLine("Min {0}", String.Join("\n", Extreme.Min(rectangles)));
                Console.WriteLine("Max {0}", String.Join("\n", Extreme.Max(rectangles)));
                Console.WriteLine();

                Console.WriteLine("Min {0}", String.Join("\n", Extreme.Min(ellipses)));
                Console.WriteLine("Max {0}", String.Join("\n", Extreme.Max(ellipses)));
                Console.WriteLine();

                Console.WriteLine("Min {0}", String.Join("\n", Extreme.Min(triangles)));
                Console.WriteLine("Max {0}", String.Join("\n", Extreme.Max(triangles)));
                Console.WriteLine();

                Console.WriteLine("Min {0}", String.Join("\n", Extreme.Min(squares)));
                Console.WriteLine("Max {0}", String.Join("\n", Extreme.Max(squares)));
                Console.WriteLine();

                Console.WriteLine("Min object: {0}", String.Join("\n", Extreme.Min(objects2D)));
                Console.WriteLine("Max object: {0}", String.Join("\n", Extreme.Max(objects2D)));
                Console.WriteLine();

                Console.WriteLine("Filtered values");
                Console.WriteLine(String.Join("\n", (numbers.Where(e => e > 4 && e < 8))));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
