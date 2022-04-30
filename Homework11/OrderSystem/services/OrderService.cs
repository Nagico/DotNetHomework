using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using OrderSystem.models;

namespace OrderSystem.services
{
    /// <summary>
    /// 订单业务类
    /// </summary>
    public class OrderService : IEnumerable<Order>
    {
        private OrderSystemContext context = new();

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
            if (context.orders.Contains(model))
                throw new ArgumentException($"{typeof(Order).Name}{model.Id} already exists.");
            model.UpdateTime = DateTime.Now;
            context.orders.Add(model);
            context.SaveChanges();
            return model;
        }

        /// <summary>
        /// 获取订单
        /// </summary>
        /// <param name="id">订单ID</param>
        /// <returns>订单对象</returns>
        public Order? Get(int id)
        {
            return context.orders.Include("customers").Include("products").Where(X => X.Id == id).FirstOrDefault();
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
            return context.orders.Where(x => match(x)).OrderBy(x => x.Id);
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
            var result = context.orders.AsEnumerable();

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
            if (!context.orders.Contains(model))
                throw new ArgumentException($"{typeof(Order).Name}{model.Id} not exists.");

            model.UpdateTime = DateTime.Now;
            context.Entry(model).State = EntityState.Modified;
            context.SaveChanges();
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
            if (!context.orders.Contains(model))
            {
                model.UpdateTime = DateTime.Now;
                context.orders.Add(model);
            }
            else
            {
                model.UpdateTime = DateTime.Now;
                context.Entry(model).State = EntityState.Modified;
            }
            context.SaveChanges();
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
            context.orders.Remove(model);
            context.SaveChanges();
        }

        public IEnumerator<Order> GetEnumerator()
        {
            foreach (var model in context.orders)
            {
                yield return model;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (var model in context.orders)
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
            return context.orders.OrderBy(func);
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
            return context.orders.OrderByDescending(func);
        }
    }
}