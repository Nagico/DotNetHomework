using Figure;

Console.WriteLine(new Rectangle(10, 20));
Console.WriteLine(new Rectangle(2.5, 10));
Console.WriteLine(new Square(10));
Console.WriteLine(new Triangle(10, 10, 15));
Console.WriteLine(new Circle(100));

try
{
    Console.WriteLine(new Triangle(new Dictionary<string, double> { { "Side1", 10 }, { "Side2", 2 }, { "Side3", 2 } }));  // Invalid Figure
}
catch (InvalidFigureException ex)
{
    Console.WriteLine(ex.Message);
}