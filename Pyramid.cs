using System;

namespace cv6
{
    public class Pyramid : Object3D
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Pyramid(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public override double ComputeSurface()
        {
            double slant1 = this.Width * Math.Sqrt(Math.Pow(this.Length / 2, 2) + Math.Pow(this.Height, 2));
            double slant2 = this.Length * Math.Sqrt(Math.Pow(this.Width / 2, 2) + Math.Pow(this.Height, 2));

            return this.Length * this.Width + slant1 + slant2;

        }

        public override double ComputeVolume()
        {
            return (this.Length * this.Width * this.Height) / 3;
        }

        public override void Draw()
        {
            Console.WriteLine("{0}, S = {1:F2}, V = {2:F2}", this.ToString(), this.ComputeSurface(), this.ComputeVolume());
        }

        public override string ToString()
        {
            return String.Format("Pyramid: l = {0}, w = {1}, h = {2}", this.Length, this.Width, this.Height);
        }
    }
}
