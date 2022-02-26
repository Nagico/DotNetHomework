namespace PrimeFactor
{
    class Program
    {
        /// <summary>
        /// 获取质因子
        /// </summary>
        /// <param name="num">数字</param>
        /// <param name="primeList">质数表</param>
        /// <returns>质因子</returns>
        private static List<int> GetPrimeFactor(int num, List<int> primeList)
        {
            var ans = new List<int>();
            var end = num;

            foreach (int prime in primeList)
            {
                if (prime > end)
                    break;

                if (num % prime == 0)
                {
                    ans.Add(prime);
                    do
                    {
                        num /= prime;
                    }
                    while (num % prime == 0);
                }
            }
            return ans;
        }

        public static void Main(string[] args)
        {
            var num = Convert.ToInt32(Console.ReadLine());

            var prime = new Prime.Prime();
            prime.CalcPrimeList(num);

            var ans = GetPrimeFactor(num, prime.primeList);
            foreach (var x in ans)
                Console.Write($"{x} ");
        }
    }
}