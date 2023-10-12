using DesignPatterns.SimpleFactory.Abstract;
using DesignPatterns.SimpleFactory.Concrete;

namespace DesignPatterns.SimpleFactory.Factory;

public static class DoorFactory
{
    public static IDoor MakeDoor(int height, int width)
    {
        return new WoodenDoor(height, width);
    }
}
