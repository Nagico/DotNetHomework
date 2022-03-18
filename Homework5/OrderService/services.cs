using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService
{
    public class CustomerService
    {
        private List<Customer> customers = new();
        
        public Customer Add(Customer customer)
        {
            if (customers.Contains(customer))
                throw new ArgumentException($"Customer{customer.Id} {customer.Name} already exists.");
            customers.Add(customer);
            return customer;
        }

        public void Delete(Customer customer)
        {
            if (!customers.Contains(customer))
                throw new ArgumentException($"Customer{customer.Id} {customer.Name} not exists.");
            customers.Remove(customer);
        }

        public IEnumerable<Customer> Query(string name)
        {
            return customers.Where(x => x.Name == name);
        }

        public Customer? Get(int id)
        {
            return customers.Where(X => X.Id == id).FirstOrDefault();
        }
    }

    public class ProductService
    {
        private List<Product> products = new();

        public Product Add(Product product)
        {
            if (products.Contains(product))
                throw new ArgumentException($"Product{product.Id} {product.Name} already exists.");
            products.Add(product);
            return product;
        }

        public void Delete(Product product)
        {
            if (!products.Contains(product))
                throw new ArgumentException($"Product{product.Id} {product.Name} not exists.");
            products.Remove(product);
        }

        public IEnumerable<Product> Query(string name)
        {
            return products.Where(x => x.Name == name);
        }

        public Product? Get(int id)
        {
            return products.Where(x => x.Id == id).FirstOrDefault();
        }
    }

    public class OrderService : IEnumerable<Order>
    {
        private List<Order> orders = new();

        public Order Add(Order order)
        {
            if (orders.Contains(order))
                throw new ArgumentException($"Order{order.Id} already exists.");
            orders.Add(order);
            return order;
        }

        public void Delete(Order order)
        {
            if (!orders.Contains(order))
                throw new ArgumentException($"Order{order.Id} not exists.");
            orders.Remove(order);
        }

        public IEnumerable<Order> Query(string? productName=null, Customer? customer=null, double? totalPrice=null)
        {
            var result = orders.AsEnumerable();

            if (customer != null)
                result = result.Where(order => order.Customer.Equals(customer));

            if (totalPrice != null)
                result = result.Where(order => order.TotalPrice == totalPrice);

            if (productName != null)
                result = result.Where(order => order.Details.Any(detail => detail.Product.Name == productName));

            return result;
        }

        public Order? Get(int id)
        {
            return orders.Where(order => order.Id == id).FirstOrDefault();
        }

        public void Sort(Func<Order, Order, int>? func=null)
        {
            if (func == null)
                func = (o1, o2) => o1.Id - o2.Id;
            orders.Sort((o1, o2) => func(o1,o2));
        }

        public IEnumerator<Order> GetEnumerator()
        {
            foreach(var order in orders)
            {
                yield return order;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (var order in orders)
            {
                yield return order;
            }
        }

        public void ForEach(Action<Order> action)
        {
            foreach (var item in this)
            {
                action(item);
            }
        }
    }
}
