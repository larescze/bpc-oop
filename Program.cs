using System;
using System.Collections.Generic;

namespace cv6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(4);
            Rectangle rectangle = new Rectangle(4, 8);
            Square square = new Square(4);
            Ellipse ellipse = new Ellipse(4, 6);
            Triangle triangle = new Triangle(6, 4, 4);
            Cuboid cuboid = new Cuboid(4, 6, 8);
            Cylinder cylinder = new Cylinder(4, 10);
            Sphere sphere = new Sphere(4);
            Pyramid pyramid = new Pyramid(4, 6, 8);

            List<GraphicObject> objects = new List<GraphicObject>() {
                circle,
                rectangle,
                square,
                ellipse,
                triangle,
                cuboid,
                cylinder,
                sphere,
                pyramid
            };

            double area = 0;
            double surface = 0;
            double volume = 0;

            foreach (var obj in objects)
            {
                Console.WriteLine(obj.Draw());

                if (obj is Object2D object2D)
                {
                    area += object2D.ComputeArea();
                }
                else if (obj is Object3D object3D)
                {
                    surface += object3D.ComputeSurface();
                    volume += object3D.ComputeVolume();
                }
                else
                {
                    Console.WriteLine("The object is neither 2D nor 3D");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Total area of 2D objects: {0:F2}", area);
            Console.WriteLine("Total surface of 3D objects: {0:F2}", surface);
            Console.WriteLine("Total volume of 3D objects: {0:F2}.", volume);

            Console.ReadLine();
        }
    }
}
