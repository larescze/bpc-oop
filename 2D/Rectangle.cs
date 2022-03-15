using System;

namespace cv6
{
    public class Rectangle : Object2D
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public override double ComputeArea()
        {
            return this.Length * this.Width;
        }

        public override string Draw()
        {
            return String.Format("{0}, S = {1:F2}", this.ToString(), this.ComputeArea());
        }

        public override string ToString()
        {
            return String.Format("Rectangle: l = {0}, w = {1}", this.Length, this.Width);
        }
    }
}
