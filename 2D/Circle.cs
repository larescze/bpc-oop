using System;

namespace cv7
{
    public class Circle : Object2D
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
            this.Area = this.ComputeArea();
        }

        public override double ComputeArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public override string ToString()
        {
            return String.Format("Circle: r = {0}, S = {1:F2}", this.Radius, this.Area);
        }
    }
}