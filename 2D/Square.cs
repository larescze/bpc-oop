using System;

namespace cv7
{
    public class Square : Object2D
    {
        public double Length { get; set; }

        public Square(double length)
        {
            this.Length = length;
            this.Area = this.ComputeArea();
        }

        public override double ComputeArea()
        {
            return Math.Pow(this.Length, 2);
        }

        public override string ToString()
        {
            return String.Format("Square: l = {0}, S = {1:F2}", this.Length, this.Area);
        }
    }
}
