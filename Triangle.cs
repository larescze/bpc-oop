using System;

namespace cv6
{
    public class Triangle : Object2D
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public override double ComputeArea()
        {
            double semiPerimeter = (this.SideA + this.SideB + this.SideC) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - this.SideA) * (semiPerimeter - this.SideB) * (semiPerimeter - this.SideC));
        }

        public override void Draw()
        {
            Console.WriteLine("{0}, S = {1:F2}", this.ToString(), this.ComputeArea());
        }

        public override string ToString()
        {
            return String.Format("Triangle: a = {0}, b = {1}, c = {2}", this.SideA, this.SideB, this.SideC);
        }
    }
}
