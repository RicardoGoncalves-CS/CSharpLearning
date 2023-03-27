using SuperShopData.Data;
using SuperShopData.Models;

namespace SuperShopData.Services
{
    public class CustomerService : ICustomerService
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

        public void CreateCustomer(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
        }

        public Customer GetCostumerById(int customerId)
        {
            return _context.Customers.FirstOrDefault(c => c.Id == customerId);
        }

        public List<Customer> GetCustomersList()
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
}
