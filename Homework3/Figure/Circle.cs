using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Circle : Figure
    {
        /// <summary>
        /// 半径
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// 初始化生成
        /// </summary>
        /// <param name="radius">半径</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// 初始化生成
        /// </summary>
        public Circle() : this(0) { }

        public override bool CheckValid()
        {
            return Radius > 0;
        }

        protected override double CalcArea()
        {
            return Math.PI * Radius * Radius;
        }

        protected override void SetRandomValue()
        {
            Radius = GetRandomDouble();
        }

        public override string ToString()
        {
            return $"[Circle] Radius: {Radius}";
        }
    }
}
