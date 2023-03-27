using SuperShopData.Data;
using SuperShopData.Models;

namespace SuperShopData.Services;

public class CustomerService : IServices<Customer>
{
    private readonly SuperShopContext _context;

    public CustomerService()
    {
        _context = new SuperShopContext();
    }

    public CustomerService(SuperShopContext context)
    {
        _context = context;
    }

    public void Create(Customer customer)
    {
        _context.Add(customer);
        _context.SaveChanges();
    }

    public Customer GetById(int customerId)
    {
        return _context.Customers.FirstOrDefault(c => c.Id == customerId);
    }

    public List<Customer> GetEntitiesList()
    {
        return _context.Customers.ToList();
    }

    public void Remove(Customer customer)
    {
        _context.Remove(customer);
        _context.SaveChanges();
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}
