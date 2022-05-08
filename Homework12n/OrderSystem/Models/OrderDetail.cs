using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderSystem.Models;

public class OrderDetail
{
    public Guid Id { get; set; }

    public virtual Product? Product { get; set; }
    public Guid ProductId { get; set; }

    public int Number { get; set; }
    public double Discount { get; set; }
    public double TotalPrice
    {
        get
        {
            if (Product == null)
                return 0;
            return Math.Round(Product.Price * Number * Discount, 2);
        }
    }
}
