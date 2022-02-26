namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            int n = 0;

            foreach (var x in Console.ReadLine().Split(' ').ToList())
            {
                try
                {
                    var num = int.Parse(x);

                    n++;

                    max = Math.Max(max, num);
                    min = Math.Min(min, num);

                    sum += num;
                }
                catch { }
            }
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Avg: {sum / n}");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}