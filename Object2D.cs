using System;

namespace cv7
{
    public abstract class Object2D : I2D, IComparable
    {
        protected double Area { get; set; }
        public abstract double ComputeArea();

        public int CompareTo(object obj)
        {
            if (!(obj is Object2D obj2D))
            {
                throw new ArgumentException("Object can't be compared");
            }
            else if (obj == null || this.Area > obj2D.Area)
            {
                return 1;
            }
            else if (this.Area == obj2D.Area)
            {
                return 0;
            }

            return -1;
        }
    }
}
