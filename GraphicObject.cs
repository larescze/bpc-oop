namespace cv6
{
    public interface IGraphicObject
    {
        string Draw();
    }

    public abstract class GraphicObject : IGraphicObject
    {
        public abstract string Draw();
    } 
}
