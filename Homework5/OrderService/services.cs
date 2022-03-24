using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService
{
    /// <summary>
    /// 模型业务基类
    /// </summary>
    /// <typeparam name="T">模型类</typeparam>
    public class Service<T> : IEnumerable<T> where T : Model
    {
        protected List<T> models = new();

        /// <summary>
        /// 添加实例
        /// </summary>
        /// <param name="model">实例对象</param>
        /// <returns>实例对象</returns>
        /// <exception cref="ArgumentException"></exception>
        public T Add(T model)
        {
            if (models.Contains(model))
                throw new ArgumentException($"{typeof(T).Name}{model.Id} already exists.");
            models.Add(model);
            return model;
        }

        /// <summary>
        /// 删除实例
        /// </summary>
        /// <param name="model">实例对象</param>
        /// <exception cref="ArgumentException"></exception>
        public void Delete(T model)
        {
            if (!models.Contains(model))
                throw new ArgumentException($"Model{model.Id} not exists.");
            models.Remove(model);
        }

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <param name="id">实例ID</param>
        /// <returns>实例对象</returns>
        public T? Get(int id)
        {
            return models.Where(X => X.Id == id).FirstOrDefault();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var model in models)
            {
                yield return model;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (var model in models)
            {
                yield return model;
            }
        }

        /// <summary>
        /// 遍历
        /// </summary>
        /// <param name="action">函数</param>
        public void ForEach(Action<T> action)
        {
            foreach (var item in this)
            {
                action(item);
            }
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="func">排序函数</param>
        public void Sort(Func<T, T, int>? func = null)
        {
            if (func == null)
                func = (o1, o2) => o1.Id - o2.Id;
            models.Sort((o1, o2) => func(o1, o2));
        }
    }

    /// <summary>
    /// 顾客业务类
    /// </summary>
    public class CustomerService : Service<Customer>
    {
        /// <summary>
        /// 获取顾客查询集
        /// </summary>
        /// <param name="name">顾客姓名</param>
        /// <returns>顾客查询集</returns>
        public IEnumerable<Customer> Query(string name)
        {
            return models.Where(x => x.Name == name);
        }

    }

    /// <summary>
    /// 产品业务类
    /// </summary>
    public class ProductService : Service<Product>
    {
        /// <summary>
        /// 获取产品查询集
        /// </summary>
        /// <param name="name">产品名称</param>
        /// <returns>产品查询集</returns>
        public IEnumerable<Product> Query(string name)
        {
            return models.Where(x => x.Name == name);
        }
    }

    /// <summary>
    /// 订单业务类
    /// </summary>
    public class OrderService : Service<Order>
    {
        /// <summary>
        /// 获取订单查询集
        /// </summary>
        /// <param name="productName">产品名称</param>
        /// <param name="customer">顾客姓名</param>
        /// <param name="totalPrice">总价</param>
        /// <returns>订单查询集</returns>
        public IEnumerable<Order> Query(string? productName = null, Customer? customer = null, double? totalPrice = null)
        {
            var result = models.AsEnumerable();

            if (customer != null)
                result = result.Where(order => order.Customer.Equals(customer));

            if (totalPrice != null)
                result = result.Where(order => order.TotalPrice == totalPrice);

            if (productName != null)
                result = result.Where(order => order.Details.Any(detail => detail.Product.Name == productName));

            return result;
        }
    }
}
