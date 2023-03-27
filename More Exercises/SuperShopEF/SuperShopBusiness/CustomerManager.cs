using SuperShopData.Models;
using SuperShopData.Services;
using System.Diagnostics;

namespace SuperShopBusiness;

public class CustomerManager
{
    private ICustomerService _service;

    public CustomerManager(ICustomerService service)
    {
        if(service == null)
        {
            throw new ArgumentException("ICustomerService object cannot be null");
        }
        _service = service;
    }

    public CustomerManager()
    {
        _service = new CustomerService();
    }

    public Customer SelectedCustomer { get; set; }

    public void SetSelectedCustomer(object selectedItem)
    {
        SelectedCustomer = (Customer)selectedItem;
    }

    public List<Customer> RetrieveAll()
    {
        return _service.GetCustomersList();
    }

    public void Create(string firstName, string lastName, string phone, string email, Address address)
    {
        Customer customer = new Customer();

        customer.FirstName = firstName;
        customer.LastName = lastName;
        customer.Phone = phone;
        customer.Email = email;
        customer.address = address;

        _service.CreateCustomer(customer);
    }

    public bool Update(int customerId, string firstName, string lastName, string phone, string email, Address address)
    {
        var customer = _service.GetCostumerById(customerId);

        if (customer == null)
        {
            Debug.WriteLine($"Customer {customerId} not found");
            return false;
        }

        customer.FirstName = firstName;
        customer.LastName = lastName;
        customer.Phone = phone;
        customer.Email = email;
        customer.address = address;

        try
        {
            _service.SaveCustomerChanges();
            SelectedCustomer = customer;
        }
        catch (Exception e)
        {
            Debug.WriteLine($"Error updating {customerId} : {e}");
            return false;
        }
        return true;
    }

    public bool Delete(int customerId)
    {
        var customer = _service.GetCostumerById(customerId);
        if (customer == null)
        {
            Debug.WriteLine($"Customer {customerId} not found");
            return false;
        }
        _service.RemoveCustomer(customer);
        return true;
    }
}
