using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    /// <summary>
    /// 图形工厂类
    /// </summary>
    public class FigureFactory
    {
        /// <summary>
        /// 已创建对象列表
        /// </summary>
        private static List<Figure> FigureList = new();

        /// <summary>
        /// 创建对象
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="args">参数</param>
        /// <returns>对象</returns>
        /// <exception cref="Exception">创建失败</exception>
        public static dynamic CreateFigure(Type? type, object[]? args = null)
        {
            if (type == null)
                throw new Exception("Invalid classname");

            dynamic obj = (Figure)Activator.CreateInstance(type, args);
            obj = Convert.ChangeType(obj, type);

            FigureList.Add(obj);

            return obj;
        }

        /// <summary>
        /// 创建对象
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="args">参数</param>
        /// <returns>对象</returns>
        /// /// <exception cref="Exception">创建失败</exception>
        public static dynamic CreateFigure(string type, object[]? args = null)
        {
            return CreateFigure(Type.GetType($"Figure.{type}, Figure"), args);
        }
    }
}
