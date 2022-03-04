using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal interface IFigure
    {
        Dictionary<string, double> Props { get; set; }
        /// <summary>
        /// 图形面积
        /// </summary>
        double Area { get; }
        
        /// <summary>
        /// 检查图形是否规范
        /// </summary>
        /// <returns>检查结果</returns>
        bool CheckValid();
    }
}
