using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = Math.Round(price, 2);
        }

        public override string? ToString()
        {
            return $"[Product {Id}]: {Name}-{Price}";
        }

        public bool Equals(Product? other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Product);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}