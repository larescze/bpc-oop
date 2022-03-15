using System;

namespace cv6
{
    public class Circle : Object2D
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double ComputeArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public override string Draw()
        {
            return String.Format("{0}, S = {1:F2}", this.ToString(), this.ComputeArea());
        }

        public override string ToString()
        {
            return String.Format("Circle: r = {0}", this.Radius);
        }
    }
}
