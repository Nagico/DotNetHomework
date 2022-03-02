using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Square : Rectangle
    {
        public Square() : base() { }

        public Square(Dictionary<string, double> props) : base(props) { }

        public Square(double[] props) : base(props) { }

        public override bool CheckValid()
        {
            return base.CheckValid() && (Props["Length"] == Props["Width"]);
        }

        protected override void SetRandomProps()
        {
            Props["Length"] = GetRandomDouble();
            Props["Width"] = Props["Length"];
        }
    }
}
