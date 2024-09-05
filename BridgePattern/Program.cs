


using BridgePattern.Models;

Shape shape = new Circle(new RedColor());
Console.WriteLine(shape.Draw());

Shape shape2 = new Square(new BlueColor());
Console.WriteLine(shape2.Draw());


Console.ReadLine();