using SuperShopData.Models;
using SuperShopData.Services;
using System.Diagnostics;

namespace SuperShopBusiness.TablesManagers;

public class CustomerManager
{
    private IServices<Customer> _service;

    public CustomerManager(IServices<Customer> service)
    {
        if (service == null)
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
        return _service.GetEntitiesList();
    }

    public Customer GetCustomerById(int customerId)
    {
        return _service.GetById(customerId);
    }

    public void Create(string firstName, string lastName, string phone, string email, Address address)
    {
        Customer customer = new Customer();

        customer.FirstName = firstName;
        customer.LastName = lastName;
        customer.Phone = phone;
        customer.Email = email;
        customer.Address = address;

        _service.Create(customer);
    }

    public bool Update(int customerId, string firstName, string lastName, string phone, string email, Address address)
    {
        var customer = _service.GetById(customerId);

        if (customer == null)
        {
            Debug.WriteLine($"Customer {customerId} not found");
            return false;
        }

        customer.FirstName = firstName;
        customer.LastName = lastName;
        customer.Phone = phone;
        customer.Email = email;
        customer.Address = address;

        try
        {
            _service.Save();
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
        var customer = _service.GetById(customerId);
        if (customer == null)
        {
            Debug.WriteLine($"Customer {customerId} not found");
            return false;
        }
        _service.Remove(customer);
        return true;
    }
}
