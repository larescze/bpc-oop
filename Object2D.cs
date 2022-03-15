namespace cv6
{
    public interface IObject2D
    {
        double ComputeArea();
    }

    public abstract class Object2D : GraphicObject, IObject2D
    {
        public abstract double ComputeArea();
    }
}
