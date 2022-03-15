using System;

namespace cv6
{
    public class Square : Object2D
    {
        public double Length { get; set; }

        public Square(double length)
        {
            this.Length = length;
        }

        public override double ComputeArea()
        {
            return Math.Pow(this.Length, 2);
        }

        public override void Draw()
        {
            Console.WriteLine("{0}, S = {1:F2}", this.ToString(), this.ComputeArea());
        }

        public override string ToString()
        {
            return String.Format("Square: l = {0}", this.Length);
        }
    }
}
