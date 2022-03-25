using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    /// <summary>
    /// 订单模型类
    /// </summary>
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetail> Details { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }

        public double TotalPrice
        {
            get
            {
                return Math.Round(Details.Sum(x => x.TotalPrice), 2);
            }
        }

        public Order() { }
        public Order(int id, Customer customer)
        {
            Id = id;
            Customer = customer;
            Details = new List<OrderDetail>();
            CreateTime = DateTime.Now;
            UpdateTime = DateTime.Now;
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

        public bool Equals(Order? other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Order);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
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