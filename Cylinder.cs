using System;

namespace cv6
{
    public class Cylinder : Object3D
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cylinder(double radius, double height)
        {
            this.Radius = radius;
            this.Height = height;
        }

        public override double ComputeSurface()
        {
            return 2 * Math.PI * Math.Pow(this.Radius, 2) + 2 * Math.PI * this.Radius * this.Height;
        }

        public override double ComputeVolume()
        {
            return Math.PI * Math.Pow(this.Radius, 2) * this.Height;
        }

        public override void Draw()
        {
            Console.WriteLine("{0}, S = {1:F2}, V = {2:F2}", this.ToString(), this.ComputeSurface(), this.ComputeVolume());
        }

        public override string ToString()
        {
            return String.Format("Cylinder: r = {0}, h = {1}", this.Radius, this.Height);
        }
    }
}
