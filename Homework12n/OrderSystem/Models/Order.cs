using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OrderSystem.Models;

public class Order
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public virtual Customer? Customer { get; set; }
    
    
    public List<OrderDetail> Details { get; set; }
    public DateTime UpdateTime { get; set; }
    public DateTime CreateTime { get; set; }

    public double TotalPrice
    {
        get
        {
            if (Details == null)
                return 0;
            return Math.Round(Details.Sum(x => x.TotalPrice), 2);
        }
    }
}