using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService
{
    /// <summary>
    /// 模型基类
    /// </summary>
    public class Model : IEquatable<Model?>
    {
        /// <summary>
        /// pk主键
        /// </summary>
        public int Id { get; set; }

        public Model()
        {
            Id = 0;
        }

        public bool Equals(Model? other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Model);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }

    /// <summary>
    /// 顾客模型类
    /// </summary>
    public class Customer : Model
    {
        private static int totalId = 0;
        public string Name { get; set; }

        public DateTime CreateTime { get; set; }

        public Customer(string name)
        {
            Id = ++totalId;
            Name = name;
            CreateTime = DateTime.Now;
        }

        public override string? ToString()
        {
            return $"[Customer {Id}]: {Name}";
        }
    }

    public class Product : Model
    {
        private static int totalId = 0;
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreateTime { get; set; }

        public Product(string name, double price)
        {
            Id = ++totalId;
            Name = name;
            Price = Math.Round(price, 2);
            CreateTime = DateTime.Now;
        }

        public override string? ToString()
        {
            return $"[Product {Id}]: {Name}-{Price}";
        }
    }

    /// <summary>
    /// 订单详情模型类
    /// </summary>
    public class OrderDetail : Model
    {
        private static int totalId = 0;
        public Product Product { get; set; }
        public int Number { get; set; }
        public double Discount { get; set; }
        public double TotalPrice
        {
            get
            {
                return Math.Round(Product.Price * Number * Discount, 2);
            }
        }

        public OrderDetail(Product product, int number, double discount)
        {
            Id = ++totalId;
            Product = product;
            Number = number;
            Discount = discount;
        }

        public override string ToString()
        {
            return
                $"Product: {Product} \t" +
                $"Number: {Number} \t" +
                $"Discount: {Discount} \t" +
                $"Total Price:{TotalPrice}";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OrderDetail);
        }

        public bool Equals(OrderDetail? other)
        {
            return other != null &&
                   EqualityComparer<Product>.Default.Equals(Product, other.Product);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Product.Id);
        }
    }

    /// <summary>
    /// 订单模型类
    /// </summary>
    public class Order : Model
    {
        private static int totalId = 0;
        public Customer Customer { get; set; }
        public List<OrderDetail> Details { get; set; }
        public double TotalPrice
        {
            get
            {
                return Math.Round(Details.Sum(x => x.TotalPrice), 2);
            }
        }
        public DateTime CreateTime { get; set; }

        public Order(Customer customer)
        {
            Id = ++totalId;
            Customer = customer;
            Details = new List<OrderDetail>();
            CreateTime = DateTime.Now;
        }

        public override string ToString()
        {
            StringBuilder details = new();
            foreach (var detail in Details)
            {
                details.AppendLine(detail.ToString());
            }
            return
                $"[Order {Id}] \n\n" +
                $"{Customer} \n\n" +
                $"[Order Details]\n" +
                $"{details} \n" +
                $"[Total Price]: {TotalPrice}";
        }

        public OrderDetail? GetOrderDetail(Product product)
        {
            return Details.Where(x => x.Product.Equals(product)).FirstOrDefault();
        }

        public OrderDetail AddOrderDetail(OrderDetail? orderDetail)
        {
            if (orderDetail == null)
                throw new ArgumentNullException(nameof(orderDetail));
            if (Details.Contains(orderDetail))
                throw new ArgumentException($"Order detail{orderDetail.Product} already exists.");
            Details.Add(orderDetail);
            return orderDetail;
        }

        public void DeleteOrderDetail(OrderDetail? orderDetail)
        {
            if (orderDetail == null)
                throw new ArgumentNullException(nameof(orderDetail));
            if (!Details.Contains(orderDetail))
                throw new ArgumentException($"Order detail{orderDetail.Product} not exists.");
            Details.Remove(orderDetail);
        }
    }
}
