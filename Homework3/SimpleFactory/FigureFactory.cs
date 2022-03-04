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
        /// 创建对象
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="args">参数</param>
        /// <returns>对象</returns>
        /// <exception cref="ArgumentException">参数错误</exception>
        /// <exception cref="NullReferenceException">创建失败</exception>
        public static dynamic CreateFigure(Type? type, object[]? args = null)
        {
            if (type == null)
                throw new ArgumentException("Invalid classname");

            dynamic obj = Activator.CreateInstance(type, args) as Figure;

            if (obj == null)
                throw new NullReferenceException("Create failed");
            obj = Convert.ChangeType(obj, type);

            return obj;
        }

        /// <summary>
        /// 创建对象
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="args">参数</param>
        /// <returns>对象</returns>
        /// <exception cref="ArgumentException">参数错误</exception>
        /// <exception cref="NullReferenceException">创建失败</exception>
        public static dynamic CreateFigure(string type, object[]? args = null)
        {
            return CreateFigure(Type.GetType($"Figure.{type}, Figure"), args);
        }
    }
}
