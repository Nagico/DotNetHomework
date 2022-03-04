using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Square : Figure
    {
        public static readonly string[] _IProps = new[] { "Side" };

        public Square(Dictionary<string, double> props) : base(_IProps, props) { }

        public Square(params double[] props) : base(_IProps, props) { }

        protected override double CalcArea()
        {
            return Props["Side"] * Props["Side"];
        }


    }
}
