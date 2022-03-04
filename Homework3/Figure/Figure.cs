using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public abstract class Figure : IFigure
    {
        /// <summary>
        /// 派生类列表
        /// </summary>
        public static List<Type> SubClass
        {
            get
            {
                return typeof(Figure).Assembly.GetTypes().Where(type => type.IsSubclassOf(typeof(Figure))).ToList();
            }
        }

        /// <summary>
        /// 参数字段列表
        /// </summary>
        public readonly string[] IProps;

        public double Area
        {
            get
            {
                if (!CheckValid())
                    throw new InvalidFigureException($"Invalid Figure: {FigureInfo}");

                return CalcArea();
            }
        }
        /// <summary>
        /// 当前图形参数
        /// </summary>
        public Dictionary<string, double> Props { get; set; }
        /// <summary>
        /// 当前图形信息
        /// </summary>
        private string FigureInfo
        {
            get
            {
                var className = this.GetType().Name;
                List<string> propsValue = new();
                foreach (var prop in Props)
                {
                    propsValue.Add($"{prop.Key}: {prop.Value}");
                }
                return $"[{className}] {string.Join(", ", propsValue)}";
            }
        }

        /// <summary>
        /// 使用字典初始化图形
        /// </summary>
        /// <param name="iProps">参数字段列表</param>
        /// <param name="props">参数字典</param>
        /// <exception cref="ArgumentException"></exception>
        public Figure(string[] iProps, Dictionary<string, double> props)
        {
            IProps = iProps ?? throw new NotImplementedException(nameof(IProps));

            var propsKey = props.Keys.ToList();
            var iPropsKey = IProps.ToList();
            if (propsKey.Count != iPropsKey.Count || propsKey.Count(t => !iPropsKey.Contains(t)) != 0)
                throw new ArgumentException("Invalid props keys");

            Props = props;
            if (!CheckValid())
                throw new InvalidFigureException($"Invalid props: {FigureInfo}");
        }

        /// <summary>
        /// 使用数组顺序初始化图形
        /// </summary>
        /// <param name="iProps">参数字段列表</param>
        /// <param name="props">参数数组</param>
        /// <exception cref="ArgumentException"></exception>
        public Figure(string[] iProps, double[] props)
        {
            IProps = iProps ?? throw new NotImplementedException(nameof(IProps));
            Props = new();
            if (props.Length != IProps.Length)
                throw new ArgumentException("Invalid props number");

            for (var i = 0; i < props.Length; i++)
                Props.Add(IProps[i], props[i]);

            if (!CheckValid())
                throw new InvalidFigureException($"Invalid props: {FigureInfo}");
        }

        /// <summary>
        /// 计算面积
        /// </summary>
        /// <returns>图形面积</returns>
        protected abstract double CalcArea();

        public virtual bool CheckValid()
        {
            foreach(var prop in Props.Values)
            {
                if (prop <= 0)
                    return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"{FigureInfo}, Area: {Area}";
        }

    }

    /// <summary>
    /// 图形无效
    /// </summary>
    public class InvalidFigureException : ApplicationException
    {
        public string error;
        private Exception innerException;

        public InvalidFigureException() { }
        public InvalidFigureException(string msg) : base(msg)
        {
            this.error = msg;
        }
        public InvalidFigureException(string msg, Exception innerException) : base(msg, innerException)
        {
            this.innerException = innerException;
            error = msg;
        }
        public string GetError()
        {
            return error;
        }
    }
}
