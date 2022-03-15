using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv6
{
    internal class Cuboid : Object3D
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Cuboid(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public override double ComputeSurface()
        {
            return 2 * (this.Length * this.Width + this.Width * this.Height + this.Length * this.Height);
        }

        public override double ComputeVolume()
        {
            return this.Length * this.Width * this.Height;
        }

        public override void Draw()
        {
            Console.WriteLine("{0}, S = {1:F2}, V = {2:F2}", this.ToString(), this.ComputeSurface(), this.ComputeVolume());
        }
        public override string ToString()
        {
           return String.Format("Cuboid: l = {0}, w = {1}, h = {2}", this.Length, this.Width, this.Height);
        }
    }
}
