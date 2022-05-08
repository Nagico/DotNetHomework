using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderSystem.Models;

namespace OrderSystem.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private OrderSystemContext _context;
    
    public ProductController(OrderSystemContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetProductList")]
    public async Task<ActionResult<IEnumerable<Product>>> GetList()
    {
        return await _context.Products.ToListAsync();
    }
    
    [HttpGet("{id}", Name = "GetProduct")]
    public async Task<ActionResult<Product>> Get(Guid id)
    {
        var result = await _context.Products.FindAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        return result;
    }
    
    [HttpPost]
    public async Task<ActionResult<Product>> Post([FromBody] Product Product)
    {
        _context.Products.Add(Product);
        await _context.SaveChangesAsync();
        return CreatedAtAction("Get", new {id = Product.Id}, Product);
    }
    
    [HttpPut("{id}")]
    public async Task<ActionResult<Product>> Put(Guid id, Product Product)
    {
        if (id != Product.Id)
        {
            return BadRequest();
        }
        _context.Entry(Product).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return CreatedAtAction("Get", new { id = Product.Id }, Product);
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<Product>> Delete(Guid id)
    {
        var Product = await _context.Products.FindAsync(id);
        if (Product == null)
        {
            return NotFound();
        }
        _context.Products.Remove(Product);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}