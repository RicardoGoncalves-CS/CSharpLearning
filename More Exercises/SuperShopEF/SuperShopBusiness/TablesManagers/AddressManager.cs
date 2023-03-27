using SuperShopData.Services;
using SuperShopData.Models;
using System.Diagnostics;

namespace SuperShopBusiness.TablesManagers;

internal class AddressManager
{
    private IServices<Address> _service;

    public AddressManager(IServices<Address> service)
    {
        if (service == null)
        {
            throw new ArgumentException("ICustomerService object cannot be null");
        }
        _service = service;
    }

    public AddressManager()
    {
        _service = new AddressService();
    }

    public Address SelectedCustomer { get; set; }

    public void SetSelectedCustomer(object selectedItem)
    {
        SelectedCustomer = (Address)selectedItem;
    }

    public List<Address> RetrieveAll()
    {
        return _service.GetEntitiesList();
    }

    public Address GetById(int addressId)
    {
        return _service.GetById(addressId);
    }

    public void Create(string number, string street, string city, string postCode, string country)
    {
        Address address = new Address();

        address.Number = number;
        address.Street = street;
        address.City = city;
        address.PostCode = postCode;
        address.Country = country;

        _service.Create(address);
    }

    public bool Update(int addressId, string number, string street, string city, string postCode, string country)
    {
        var address = _service.GetById(addressId);

        if (address == null)
        {
            Debug.WriteLine($"Customer {addressId} not found");
            return false;
        }

        address.Number = number;
        address.Street = street;
        address.City = city;
        address.PostCode = postCode;
        address.Country = country;

        try
        {
            _service.Save();
            SelectedCustomer = address;
        }
        catch (Exception e)
        {
            Debug.WriteLine($"Error updating {addressId} : {e}");
            return false;
        }
        return true;
    }

    public bool Delete(int addressId)
    {
        var address = _service.GetById(addressId);
        if (address == null)
        {
            Debug.WriteLine($"Address {addressId} not found");
            return false;
        }
        _service.Remove(address);
        return true;
    }
}
