using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public abstract class Figure : IFigure
    {
        public double Area
        {
            get
            {
                if (CheckValid())
                    return CalcArea();
                else
                    throw new InvalidOperationException($"Invalid Figure: {FigureInfo}");
            }
        }
        /// <summary>
        /// 当前图形参数
        /// </summary>
        public Dictionary<string, double> Props { get; set; }
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
        /// 随机化参数最大值
        /// </summary>
        private readonly double _random_max = 100;
        /// <summary>
        /// 随机化参数最小值
        /// </summary>
        private readonly double _random_min = 10;
        /// <summary>
        /// 随机数发生器
        /// </summary>
        private Random _random = new();
        /// <summary>
        /// 参数字段列表
        /// </summary>
        private readonly string[] IProps;
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
        /// 默认初始化图形
        /// </summary>
        /// <param name="iProps">参数字段列表</param>
        public Figure(string[] iProps)
        {
            IProps = iProps ?? throw new NotImplementedException(nameof(IProps));
            Props = new();
            foreach (var prop in IProps)
            {
                Props.Add(prop, 0.0d);
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
            Props = new();
            var propsKey = props.Keys.ToList();
            var iPropsKey = IProps.ToList();
            if (propsKey.Count != iPropsKey.Count || propsKey.Count(t => !iPropsKey.Contains(t)) != 0)
                throw new ArgumentException("Invalid Props Keys");

            Props = props;
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
                throw new ArgumentException("Invalid Props Number");

            for (var i = 0; i < props.Length; i++)
                Props.Add(IProps[i], props[i]);
        }

        /// <summary>
        /// 产生指定大小范围内的随机数
        /// </summary>
        /// <returns>随机结果</returns>
        protected double GetRandomDouble()
        {
            return _random.NextDouble() * (_random_max - _random_min) + _random_min;
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

        /// <summary>
        /// 设置随机参数
        /// </summary>
        protected virtual void SetRandomProps()
        {
            foreach (var prop in Props.Keys)
            {
                Props[prop] = GetRandomDouble();
            }
        }

        public void Random()
        {
            while (!CheckValid())
            {
                SetRandomProps();
            }
        }

        public override string ToString()
        {
            return $"{FigureInfo}, Area: {Area}";
        }

    }
}
