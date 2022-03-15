using System;

namespace cv6
{
    public class Ellipse : Object2D
    {
        public double MajorRadius { get; set; }
        public double MinorRadius { get; set; }

        public Ellipse(double majorRadius, double minorRadius)
        {
            this.MajorRadius = majorRadius;
            this.MinorRadius = minorRadius;
        }
        public override double ComputeArea()
        {
            return Math.PI * this.MajorRadius * this.MinorRadius;
        }

        public override void Draw()
        {
            Console.WriteLine("{0}, S = {1:F2}", this.ToString(), this.ComputeArea());
        }

        public override string ToString()
        {
            return String.Format("Ellipse: a = {0}, b = {1}", this.MajorRadius, this.MinorRadius);
        }
    }
}
