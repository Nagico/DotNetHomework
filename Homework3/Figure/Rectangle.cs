using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Rectangle : Figure
    {
        /// <summary>
        /// 长
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// 宽
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// 初始化生成
        /// </summary>
        /// <param name="length">长</param>
        /// <param name="width">宽</param>
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// 初始化生成
        /// </summary>
        public Rectangle() : this(0, 0) { }

        public override bool CheckValid()
        {
            return Length > 0 && Width > 0;
        }

        protected override double CalcArea()
        {
            return Length * Width;
        }

        protected override void SetRandomValue()
        {
            Length = GetRandomDouble();
            Width = GetRandomDouble();
        }

        public override string ToString()
        {
            return $"[Rectangle] Length: {Length} Width: {Width}";
        }
    }
}
