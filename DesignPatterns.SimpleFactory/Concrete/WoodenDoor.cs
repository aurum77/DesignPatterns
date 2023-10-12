using DesignPatterns.SimpleFactory.Abstract;

namespace DesignPatterns.SimpleFactory.Concrete;

public class WoodenDoor : IDoor
{
    private int Height { get; set; }
    private int Width { get; set; }

    public WoodenDoor(int height, int width)
    {
        Height = height;
        Width = width;
    }

    public int GetHeight()
    {
        return Height;
    }

    public int GetWidth()
    {
        return Width;
    }
}
