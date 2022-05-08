using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderSystem.Models;

namespace OrderSystem.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomerController : ControllerBase
{
    private OrderSystemContext _context;
    
    public CustomerController(OrderSystemContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetCustomerList")]
    public async Task<ActionResult<IEnumerable<Customer>>> GetList()
    {
        return await _context.Customers.ToListAsync();
    }
    
    [HttpGet("{id}", Name = "GetCustomer")]
    public async Task<ActionResult<Customer>> Get(Guid id)
    {
        var result = await _context.Customers.FindAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        return result;
    }
    
    [HttpPost]
    public async Task<ActionResult<Customer>> Post([FromBody] Customer customer)
    {
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();
        return CreatedAtAction("Get", new {id = customer.Id}, customer);
    }
    
    [HttpPut("{id}")]
    public async Task<ActionResult<Customer>> Put(Guid id, Customer customer)
    {
        if (id != customer.Id)
        {
            return BadRequest();
        }
        _context.Entry(customer).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return CreatedAtAction("Get", new { id = customer.Id }, customer);
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<Customer>> Delete(Guid id)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer == null)
        {
            return NotFound();
        }
        _context.Customers.Remove(customer);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}