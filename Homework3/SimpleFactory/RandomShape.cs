using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal static class RandomShape
    {
        /// <summary>
        /// 随机化参数最大值
        /// </summary>
        private static readonly double _random_max = 100;
        /// <summary>
        /// 随机化参数最小值
        /// </summary>
        private static readonly double _random_min = 10;

        /// <summary>
        /// 产生指定大小范围内的随机数
        /// </summary>
        /// <returns>随机结果</returns>
        private static double GetRandomDouble()
        {
            return new Random().NextDouble() * (_random_max - _random_min) + _random_min;
        }

        /// <summary>
        /// 设置随机参数
        /// </summary>
        public static List<double> GetRandomProps(int count)
        {
            List<double> randomProps = new();
            for (int i = 0; i < count; i++)
                randomProps.Add(GetRandomDouble());
            return randomProps;
        }
    }
}
