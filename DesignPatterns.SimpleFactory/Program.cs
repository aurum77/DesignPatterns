using DesignPatterns.SimpleFactory.Factory;

// Simple factory simply generates an instance for client
// without exposing any instantiation logic to the client
var door = DoorFactory.MakeDoor(80, 30);

Console.WriteLine($"Height of door is: {door.GetHeight()}");
Console.WriteLine($"Width of door is: {door.GetWidth()}");
