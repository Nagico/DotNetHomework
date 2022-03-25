using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    /// <summary>
    /// 订单详情模型类
    /// </summary>
    [Serializable]
    public class OrderDetail
    {
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

        public OrderDetail() { }
        public OrderDetail(Product product, int number, double discount)
        {
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
}