using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Rectangle : Figure
    {
        public static readonly string[] _IProps = new[] { "Length", "Width" };

        public Rectangle(Dictionary<string, double> props) : base(_IProps, props) { }

        public Rectangle(params double[] props) : base(_IProps, props) { }

        protected override double CalcArea()
        {
            return Props["Length"] * Props["Width"];
        }
    }
}
