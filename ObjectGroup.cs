namespace cv6
{
    public interface IObject
    {
        void Draw();
    }

    public abstract class ObjectGroup : IObject
    {
        public abstract void Draw();
    }
}
