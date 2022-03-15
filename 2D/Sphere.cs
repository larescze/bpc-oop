using System;

namespace cv6
{
    public class Sphere : Object3D
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            this.Radius = radius;
        }
        public override double ComputeSurface()
        {
            return 4 * Math.PI * Math.Pow(this.Radius, 2);
        }

        public override double ComputeVolume()
        {
            return 4 / 3 * Math.PI * Math.Pow(this.Radius, 3);
        }

        public override string Draw()
        {
            return String.Format("{0}, S = {1:F2}, V = {2:F2}", this.ToString(), this.ComputeSurface(), this.ComputeVolume());
        }

        public override string ToString()
        {
            return String.Format("Sphere: r = {0}", this.Radius);
        }
    }
}
