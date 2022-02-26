namespace Eratosthenes
{
    class Eratosthenes
    {
        static void Main(string[] args)
        {
            var prime = new Prime.Prime();

            prime.CalcPrimeList(100);

            foreach (var item in prime.primeList)
                Console.Write($"{item} ");
        }
    }
}