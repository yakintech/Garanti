using ProxyPattern.Models;

IImage image = new ProxyImage("test.jpg");
IImage image2 = new ProxyImage("test2.jpg");



Console.WriteLine("Images created!");



image.Display();
image.Display();



image2.Display();

