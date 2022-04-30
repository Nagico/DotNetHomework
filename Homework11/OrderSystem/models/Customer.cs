using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.models
{
    /// <summary>
    /// 顾客模型类
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }


        public Customer() { }

        public Customer(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public override string? ToString()
        {
            return $"[Customer {Id}]: {Name}";
        }

        public bool Equals(Customer? other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Customer);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}