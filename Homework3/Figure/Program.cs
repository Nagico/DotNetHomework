using Figure;

Console.WriteLine(new Rectangle(new Dictionary<string, double> { { "Length", 10 }, { "Width", 20 } }));
Console.WriteLine(new Rectangle(new double[] { 2.5, 10 }));
Console.WriteLine(new Square(new double[] { 10, 10 }));
Console.WriteLine(new Triangle(new double[] { 10, 10, 15 }));
Console.WriteLine(new Circle(new double[] { 100 }));

try
{
    Console.WriteLine(new Triangle(new Dictionary<string, double> { { "Side1", 10 }, { "Side2", 2 }, { "Side3", 2 } }));  // Invalid Figure
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}