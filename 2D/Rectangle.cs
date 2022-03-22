using System;

namespace cv7
{
    public class Rectangle : Object2D
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
            this.Area = this.ComputeArea();
        }

        public override double ComputeArea()
        {
            return this.Length * this.Width;
        }

        public override string ToString()
        {
            return String.Format("Rectangle: l = {0}, w = {1}, S = {2:F2}", this.Length, this.Width, this.Area);
        }
    }
}
