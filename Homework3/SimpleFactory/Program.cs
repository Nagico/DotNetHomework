using Figure;

var FigureTypeList = Figure.Figure.SubClass;
Random _random = new Random();
double AreaSum = 0.0d;

for (int i = 0; i < 10; i++)
{
    int index = _random.Next(FigureTypeList.Count);
    var type = FigureTypeList[index]; // 随机选取图形类型

    Figure.Figure? figure = null;

    while (figure == null)
    {
        try
        {
            figure = FigureFactory.CreateFigure(type);
        }
        catch (System.Reflection.TargetInvocationException ex) when (ex.InnerException is Figure.InvalidFigureException) { }
    }
    
    AreaSum += figure.Area;
    Console.WriteLine($"Create figure{i}\n{figure}");
}

Console.WriteLine($"Area sum: {AreaSum}");