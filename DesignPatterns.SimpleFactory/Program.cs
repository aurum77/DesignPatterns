using DesignPatterns.SimpleFactory.Factory;

var door = DoorFactory.MakeDoor(80, 30);

Console.WriteLine($"Height of door is: {door.GetHeight()}");
Console.WriteLine($"Width of door is: {door.GetWidth()}");
