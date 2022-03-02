using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Triangle : Figure
    {
        static readonly string[] _IProps = new[] { "Side1", "Side2", "Side3" };
        public Triangle() : base(_IProps) { }

        public Triangle(Dictionary<string, double> props) : base(_IProps, props) { }

        public Triangle(double[] props) : base(_IProps, props) { }

        public override bool CheckValid()
        {
            return base.CheckValid() && (Props["Side1"] + Props["Side2"] > Props["Side3"]) && (Props["Side1"] + Props["Side3"] > Props["Side2"]) && (Props["Side2"] + Props["Side3"] > Props["Side1"]);
        }

        protected override double CalcArea()
        {
            double p = (Props["Side1"] + Props["Side2"] + Props["Side3"]) / 2;
            return Math.Sqrt(p * (p - Props["Side1"]) * (p - Props["Side2"]) * (p - Props["Side3"]));
        }
    }
}
