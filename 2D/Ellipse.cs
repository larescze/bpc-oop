using System;

namespace cv7
{
    internal class Ellipse : Object2D
    {
        public double MajorRadius { get; set; }
        public double MinorRadius { get; set; }

        public Ellipse(double majorRadius, double minorRadius)
        {
            this.MajorRadius = majorRadius;
            this.MinorRadius = minorRadius;
            this.Area = this.ComputeArea();
        }

        public override double ComputeArea()
        {
            return Math.PI * this.MajorRadius * this.MinorRadius;
        }

        public override string ToString()
        {
            return String.Format("Ellipse: a = {0}, b = {1}, S = {2:F2}", this.MajorRadius, this.MinorRadius, this.Area);
        }
    }
}
