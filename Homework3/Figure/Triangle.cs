using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Triangle : Figure
    {
        /// <summary>
        /// 边1
        /// </summary>
        public double Side1 { get; set; }
        /// <summary>
        /// 边2
        /// </summary>
        public double Side2 { get; set; }
        /// <summary>
        /// 边3
        /// </summary>
        public double Side3 { get; set; }

        /// <summary>
        /// 初始化生成
        /// </summary>
        /// <param name="side1">边1</param>
        /// <param name="side2">边2</param>
        /// <param name="side3">边3</param>
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        /// <summary>
        /// 初始化生成
        /// </summary>
        public Triangle() : this(0, 0, 0) { }

        public override bool CheckValid()
        {
            return (Side1 + Side2 > Side3) && (Side1 + Side3 > Side2) && (Side2 + Side3 > Side1);
        }

        protected override double CalcArea()
        {
            double p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        protected override void SetRandomValue()
        {
            Side1 = GetRandomDouble();
            Side2 = GetRandomDouble();
            Side3 = GetRandomDouble();
        }

        public override string ToString()
        {
            return $"[Triangle] Side1: {Side1} Side2: {Side2} Side3: {Side3}";
        }
    }
}
