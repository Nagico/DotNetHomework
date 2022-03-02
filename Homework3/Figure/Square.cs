using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Square : Rectangle
    {
        /// <summary>
        /// 初始化生成
        /// </summary>
        /// <param name="length">边长</param>
        public Square(double length = 0) : base(length, length) { }

        /// <summary>
        /// 初始化生成
        /// </summary>
        public Square() : this(0) { }

        public override bool CheckValid()
        {
            return base.CheckValid() && (Length == Width);
        }

        protected override void SetRandomValue()
        {
            Length = GetRandomDouble();
            Width = Length;
        }

        public override string ToString()
        {
            return $"[Square] Length: {Length}";
        }
    }
}
