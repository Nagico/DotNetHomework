using Figure;

var FigureTypeList = Figure.Figure.SubClass;
Random _random = new Random();
double AreaSum = 0.0d;

for (int i = 0; i < 10; i++)
{
    int index = _random.Next(FigureTypeList.Count);
    var type = FigureTypeList[index];

    var figure = FigureFactory.CreateFigure(type);
    figure.Random();
    AreaSum += figure.Area;
    Console.WriteLine($"Create figure{i}\n{figure}\n");
}

Console.WriteLine($"Area sum: {AreaSum}");