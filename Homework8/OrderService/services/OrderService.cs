using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using OrderSystem.models;
using OrderSystem.utils;

namespace OrderSystem.services
{
    /// <summary>
    /// 订单业务类
    /// </summary>
    public class OrderService : IEnumerable<Order>
    {
        protected List<Order> orders = new();

        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="model">订单对象</param>
        /// <returns>订单对象</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Order Create(Order model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));
            if (orders.Contains(model))
                throw new ArgumentException($"{typeof(Order).Name}{model.Id} already exists.");
            orders.Add(model);
            model.UpdateTime = DateTime.Now;
            return model;
        }

        /// <summary>
        /// 获取订单
        /// </summary>
        /// <param name="id">订单ID</param>
        /// <returns>订单对象</returns>
        public Order? Get(int id)
        {
            var model = orders.Where(X => X.Id == id).FirstOrDefault();
            if (model == null)
                return null;
            return Util.DeepCopy(model);
        }

        /// <summary>
        /// 获取订单查询集
        /// </summary>
        /// <param name="match">查询函数</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IEnumerable<Order> QueryAll(Predicate<Order> match)
        {
            if (match == null)
                throw new ArgumentNullException(nameof(match));
            return orders.Where(x => match(x)).OrderBy(x => x.Id);
        }

        /// <summary>
        /// 获取订单查询集
        /// </summary>
        /// <param name="productName">产品名称</param>
        /// <param name="customer">顾客姓名</param>
        /// <param name="totalPrice">总价</param>
        /// <returns>订单查询集</returns>
        public IEnumerable<Order> QueryAll(string? productName = null, Customer? customer = null, double? totalPrice = null)
        {
            var result = orders.AsEnumerable();

            if (customer != null)
                result = result.Where(order => order.Customer.Equals(customer));

            if (totalPrice != null)
                result = result.Where(order => order.TotalPrice == totalPrice);

            if (productName != null)
                result = result.Where(order => order.Details.Any(detail => detail.Product.Name == productName));

            return result.OrderBy(x => x.Id);
        }

        /// <summary>
        /// 更新订单
        /// </summary>
        /// <param name="model">订单对象</param>
        /// <returns>订单对象</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Order Update(Order model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));
            if (!orders.Contains(model))
                throw new ArgumentException($"{typeof(Order).Name}{model.Id} not exists.");

            orders[orders.IndexOf(model)] = model;

            model.UpdateTime = DateTime.Now;
            return model;
        }

        /// <summary>
        /// 创建或更新
        /// </summary>
        /// <param name="model">订单对象</param>
        /// <returns>订单对象</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Order CreateOrUpdate(Order model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));
            if (!orders.Contains(model))
            {
                orders.Add(model);
                model.UpdateTime = DateTime.Now;
            }
            else
            {
                orders[orders.IndexOf(model)] = model;
                model.UpdateTime = DateTime.Now;
            }
            return model;
        }

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="id">订单ID</param>
        public void Delete(int id)
        {
            Delete(Get(id));
        }

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="model">订单对象</param>
        public void Delete(Order? model)
        {
            if (model == null)
                return;
            orders.Remove(model);
        }

        public IEnumerator<Order> GetEnumerator()
        {
            foreach (var model in orders)
            {
                yield return model;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (var model in orders)
            {
                yield return model;
            }
        }

        /// <summary>
        /// 遍历
        /// </summary>
        /// <param name="action">函数</param>
        public void ForEach(Action<Order> action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));
            foreach (var item in this)
            {
                action(item);
            }
        }

        /// <summary>
        /// 升序排序
        /// </summary>
        /// <param name="func">排序属性</param>
        /// <returns>查询集</returns>
        public IEnumerable<Order> OrderBy(Func<Order, IComparable>? func=null)
        {
            if (func == null)
                func = o => o.Id;
            return orders.OrderBy(func);
        }

        /// <summary>
        /// 降序排序
        /// </summary>
        /// <param name="func">排序属性</param>
        /// <returns>查询集</returns>
        public IEnumerable<Order> OrderByDescending(Func<Order, IComparable>? func = null)
        {
            if (func == null)
                func = o => o.Id;
            return orders.OrderByDescending(func);
        }


        /// <summary>
        /// 导出Xml
        /// </summary>
        /// <param name="filename">文件名</param>
        public void Export(string filename)
        {
            var serializer = new XmlSerializer(typeof(List<Order>));
            using var stream = new FileStream(filename, FileMode.Create);
            serializer.Serialize(stream, orders);
        }

        /// <summary>
        /// 导入Xml
        /// </summary>
        /// <param name="filename">文件名</param>
        public (int, int) Import(string filename)
        {
            var serializer = new XmlSerializer(typeof(List<Order>));
            using var stream = new FileStream(filename, FileMode.Open);
            var tmp_orders = (List<Order>)(serializer.Deserialize(stream) ?? new ArgumentException($"cannot import data from {filename}"));
            int cnt = tmp_orders.Count;
            int suc = 0;
            foreach (var item in tmp_orders)
            {
                if (orders.Contains(item))
                    continue;
                orders.Add(item);
                suc++;
            }
            return (cnt, suc);
        }
    }
}