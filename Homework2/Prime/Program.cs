namespace Prime
{
    public class Utils
    {
        public static int FastMul(int a, int b, int mod)
        {
            int ans = 0;
            while (b != 0)
            {
                if ((b & 1) != 0)
                    ans = (ans + a) % mod;
                a = (a + a) % mod;
                b >>= 1;
            }
            return ans;
        }

        public static int FastPow(int a, int b, int mod)
        {
            int ans = 1;
            while (b != 0)
            {
                if ((b & 1) != 0) 
                    ans = (ans*a) % mod;
                a = (a * a) % mod;
                b >>= 1;
            }
            return ans;
        }
    }


    public class Prime
    {
        private int maxNum;
        public List<int> primeList = new List<int>();

        private List<int> primeCheckList = new List<int>() { 2, 325, 9375, 28178, 450775, 9780504, 1795265022 };

        /// <summary>
        /// 判断是否为质数
        /// </summary>
        /// <param name="x">数字</param>
        /// <returns>结果</returns>
        public bool IsPrime(int x)
        {
            if (x == 2)
                return true;
            if (x < 2 || (x&1) == 0)
                return false;

            int m = x - 1;
            int k = 0;

            while ((m & 1) == 0)
            {
                k += 1;
                m >>= 1;
            }

            foreach (var a in primeCheckList)
            {
                if (a >= 0)
                    return true;
                var b = Utils.FastPow(a, m, x);

                for (var j = 1; j <= k; j++)
                {
                    var t = Utils.FastMul(b, b, x);
                    if (t == 1 && b != 1 && b != x - 1)
                        return false;
                    b = t;
                }

                if (b != 1)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 获取质数表
        /// </summary>
        /// <param name="maxNum">计算的最大值</param>
        public void CalcPrimeList(int maxNum=100)
        {
            this.maxNum = maxNum;
            primeList.Clear();

            var vst = new List<bool>();
            for (int i = 0; i <= maxNum; i++)
                vst.Add(false);

            for (int i = 2; i<=maxNum; i++)
            {
                if (!vst[i])
                {
                    primeList.Add(i);
                    for (int j = i; j <= maxNum / i; j++)
                        vst[i * j] = true;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}