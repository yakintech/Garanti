

using OOPMix.AbstractSample;
using OOPMix.StaticSample;

Square square = new Square();
square.SideLength = 5;
Console.WriteLine("Square Area: " + square.CalcArea());

Circle circle = new Circle();
circle.Radius = 5;
Console.WriteLine("Circle Area: " + circle.CalcArea());


square.DisplayInfo();
circle.DisplayInfo();


string reversed = StringUtilities.Reverse("Hello World");
Console.WriteLine(reversed);

string titleCased = StringUtilities.ToTitleCase("hello world");
Console.WriteLine(titleCased);

string upperCased = StringUtilities.ToUpperCase("hello world");
Console.WriteLine(upperCased);

Console.ReadLine();


