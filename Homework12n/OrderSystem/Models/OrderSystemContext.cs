using Microsoft.EntityFrameworkCore;

namespace OrderSystem.Models;

public class OrderSystemContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }

    public OrderSystemContext(DbContextOptions<OrderSystemContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}