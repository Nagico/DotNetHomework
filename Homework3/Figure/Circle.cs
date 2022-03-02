using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Circle : Figure
    {
        static readonly string[] _IProps = new[] { "Radius" };
        public Circle() : base(_IProps) { }

        public Circle(Dictionary<string, double> props) : base(_IProps, props) { }

        public Circle(double[] props) : base(_IProps, props) { }

        protected override double CalcArea()
        {
            return Math.PI * Props["Radius"] * Props["Radius"];
        }
    }
}
