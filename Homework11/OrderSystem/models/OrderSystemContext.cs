using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OrderSystem.models
{
    public class OrderSystemContext : DbContext
    {
        private static readonly string _connectionString = (string)((JObject)JsonConvert.DeserializeObject(File.ReadAllText("appsettings.json")))["ConnectionStrings"]["Database"];
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }


        public OrderSystemContext()
        {
            if (_connectionString == null)
                throw new Exception("database config string not found");
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
    }
}
