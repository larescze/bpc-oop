namespace cv6
{
    public interface IObject3D
    {
        double ComputeSurface();
        double ComputeVolume();
    }

    public abstract class Object3D : ObjectGroup, IObject3D
    {
        public abstract double ComputeSurface();

        public abstract double ComputeVolume();
    }
}
