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
        public static Figure CreateFigure(Type? type, params double[]? args)
        {
            if (type == null)
                throw new ArgumentException("Invalid classname");

            if (args == null || args.Length == 0)
            {
                var _IProps = type.GetField("_IProps") ?? throw new NotImplementedException();

                var iProps = (IEnumerable<string>)(_IProps.GetValue(null) ?? throw new NotImplementedException());
                args = RandomShape.GetRandomProps(iProps.Count()).Cast<double>().ToArray();
            }


            if (Activator.CreateInstance(type, args) is not Figure obj)
                throw new NullReferenceException("Create failed");

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
        public static Figure CreateFigure(string type, params double[]? args)
        {
            return CreateFigure(Type.GetType($"Figure.{type}, Figure"), args);
        }
    }
}
