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
                    throw new InvalidOperationException("Invalid figure");
            }
        }
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
        protected readonly double _random_max = 100;
        /// <summary>
        /// 随机化参数最小值
        /// </summary>
        protected readonly double _random_min = 10;
        /// <summary>
        /// 随机数发生器
        /// </summary>
        private Random _random = new();
        /// <summary>
        /// 参数字段列表
        /// </summary>
        private static readonly string[]? IProps;

        public Figure()
        {
            if (IProps == null)
                throw new NotImplementedException(nameof(IProps));
            Props = new();
            foreach(var prop in IProps)
            {
                Props.Add(prop, 0.0d);
            }
        }

        public Figure(Dictionary<string, double> props)
        {
            if (IProps == null)
                throw new NotImplementedException(nameof(IProps));
            Props = new();

            var propsKey = props.Keys.ToList();
            var iPropsKey = IProps.ToList();
            if (propsKey.Count != iPropsKey.Count || propsKey.Count(t => !iPropsKey.Contains(t)) != 0)
                throw new ArgumentException("Invalid props keys");

            Props = props;
        }

        public Figure(double[] props)
        {
            if (IProps == null)
                throw new NotImplementedException(nameof(IProps));
            Props = new();

            if (props.Length != IProps.Length)
                throw new ArgumentException("Invalid props keys");

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

        public abstract bool CheckValid();

        /// <summary>
        /// 设定随机参数
        /// </summary>
        protected abstract void SetRandomValue();

        public void Random()
        {
            while (!CheckValid())
            {
                SetRandomValue();
            }
        }

    }
}
