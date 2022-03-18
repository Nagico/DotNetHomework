using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService
{
    public class Customer : IEquatable<Customer?>
    {
        private static int totalId = 0;
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime CreateTime { get; set; }

        public Customer(string name)
        {
            Id = ++totalId;
            Name = name;
            CreateTime = DateTime.Now;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Customer);
        }

        public bool Equals(Customer? other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string? ToString()
        {
            return $"[Customer {Id}]: {Name}";
        }
    }

    public class Product : IEquatable<Product?>
    {
        private static int totalId = 0;
        public int Id { get; set; }
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

        public override bool Equals(object? obj)
        {
            return Equals(obj as Product);
        }

        public bool Equals(Product? other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string? ToString()
        {
            return $"[Product {Id}]: {Name}-{Price}";
        }
    }

    public class OrderDetail : IEquatable<OrderDetail?>
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

    public class Order : IEquatable<Order?>
    {
        private static int totalId = 0;
        public int Id { get; set; }

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

        public override bool Equals(object? obj)
        {
            return Equals(obj as Order);
        }

        public bool Equals(Order? other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
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
            return Details.Where(x=>x.Product.Equals(product)).FirstOrDefault();
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
