namespace cv6
{
    public interface IGroup
    {
        void Draw();
    }

    public abstract class ObjectGroup : IGroup
    {
        public abstract void Draw();
    }
}
