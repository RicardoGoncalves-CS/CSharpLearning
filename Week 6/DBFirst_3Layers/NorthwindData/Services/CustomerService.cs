using System.Collections.Generic;
using System.Linq;

namespace NorthwindData.Services;

public class CustomerService : ICustomerService 
{
    private readonly NorthwindContext _context;

    public CustomerService()
    {
        _context = new NorthwindContext();
    }

    public CustomerService(NorthwindContext context)
    {
        _context = context;
    }

    public void CreateCustomer(Customer customer)
    {
        _context.Add(customer);
        _context.SaveChanges();
    }

    public Customer GetCustomerById(string customerId)
    {
        return _context.Customers.FirstOrDefault(c => c.CustomerId == customerId);
    }

    public List<Customer> GetCustomerList()
    {
        return _context.Customers.ToList();
    }

    public void RemoveCustomer(Customer customer)
    {
        _context.Remove(customer);
        _context.SaveChanges();
    }

    public void SaveCustomerChanges()
    {
        _context.SaveChanges();
    }
}
