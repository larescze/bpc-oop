using System;

namespace cv7
{
    public abstract class Object2D : I2D, IComparable
    {
        protected double Area { get; set; }
        public abstract double ComputeArea();

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Object2D obj2D = obj as Object2D;

            if (obj2D != null)
            {
                return this.ComputeArea().CompareTo(obj2D.ComputeArea());
            }
            else
            {
                throw new ArgumentException("Object can't be compared");
            }
        }
    }
}