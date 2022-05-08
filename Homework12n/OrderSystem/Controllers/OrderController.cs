using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderSystem.Models;

namespace OrderSystem.Controllers;

[ApiController]
[Route("api/orders")]
public class OrderController : ControllerBase
{
    private OrderSystemContext _context;
    
    public OrderController(OrderSystemContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetOrderList")]
    public async Task<ActionResult<IEnumerable<Order>>> GetOrderList(
        Guid? customerId, double? totalPrice, string? productName,
        string? orderBy = "Id", int pageSize = 10, int pageNumber = 1)
    {
        return await BuildQuery(customerId, totalPrice, productName)
            .Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToListAsync();
    }
    
    [HttpGet("{id}", Name = "GetOrder")]
    public async Task<ActionResult<Order>> GetOrder(Guid id)
    {
        var order = await _context.Orders.Include("Details").Include("Details.Product").Include("Customer").SingleOrDefaultAsync(x => x.Id == id);
        if (order == null)
        {
            return NotFound();
        }
        return order;
    }
    
    [HttpPost]
    public async Task<ActionResult<Order>> PostOrder([FromBody] Order order)
    {
        FixFK(order);
        order.CreateTime = DateTime.Now;
        order.UpdateTime = DateTime.Now;
        await _context.Orders.AddAsync(order);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetOrder", new {id = order.Id}, order);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Order>> PutOrder(Guid id, Order newOrder)
    {
        if (id != newOrder.Id)
        {
            return BadRequest();
        }
        var order = await _context.Orders.Include("Details").SingleOrDefaultAsync(x => x.Id == id);
        if (order == null)
        {
            return NotFound();
        }
        newOrder.UpdateTime = DateTime.Now;
        newOrder.CreateTime = order.CreateTime;
        FixFK(newOrder);
        _context.RemoveRange(order.Details);
        _context.Remove(order);
        await _context.SaveChangesAsync();
        _context.Orders.Add(newOrder);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetOrder", new { id = newOrder.Id }, newOrder);
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<Order>> DeleteOrder(Guid id)
    {
        var order = await _context.Orders.Include("Details").SingleOrDefaultAsync(x => x.Id == id);
        if (order == null)
        {
            return NotFound();
        }
        _context.RemoveRange(order.Details);
        _context.Remove(order);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    private IQueryable<Order> BuildQuery(Guid? customerId, double? totalPrice, string? productName)
    {
        IQueryable<Order> query = _context.Orders.Include("Details").Include("Details.Product").Include("Customer");
        if (customerId != null)
            query = query.Where(order => order.CustomerId == customerId);

        if (totalPrice != null)
            query = query.Where(order => -0.01 < order.TotalPrice - totalPrice && order.TotalPrice - totalPrice < 0.01);

        if (productName != null)
            query = query.Where(order => order.Details.Any(detail => detail.Product.Name == productName));
        
        return query;
    }

    private void FixFK(Order order)
    {
        order.Customer = _context.Customers.Where(x => x.Id == order.CustomerId).FirstOrDefault();

        order.Details.ForEach(detail =>
        {
            if (detail != null)
            {
                detail.Product = _context.Products.Where(x => x.Id == detail.ProductId).FirstOrDefault();
            }
        });
    }
}