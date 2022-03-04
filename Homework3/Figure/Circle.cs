using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Circle : Figure
    {
        public static readonly string[] _IProps = new[] { "Radius" };

        public Circle(Dictionary<string, double> props) : base(_IProps, props) { }

        public Circle(params double[] props) : base(_IProps, props) { }

        protected override double CalcArea()
        {
            return Math.PI * Props["Radius"] * Props["Radius"];
        }
    }
}
