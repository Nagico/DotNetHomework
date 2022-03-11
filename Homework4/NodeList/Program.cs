using NodeList;

NodeList<int> list = new NodeList<int>();

for (int i = 0; i < 10; i++)
    list.Add(i);

int max = int.MinValue;
int min = int.MaxValue;
int sum = 0;

list.ForEach((x) =>
{
    Console.WriteLine(x);
    max = Math.Max(max, x);
    min = Math.Min(min, x);
    sum += x;
});

Console.WriteLine($"max: {max}");
Console.WriteLine($"min: {min}");
Console.WriteLine($"sum: {sum}");