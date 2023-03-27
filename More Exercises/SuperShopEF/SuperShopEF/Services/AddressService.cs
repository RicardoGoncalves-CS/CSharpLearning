using SuperShopData.Data;
using SuperShopData.Models;

namespace SuperShopData.Services;

public class AddressService : IServices<Address>
{
    private readonly SuperShopContext _context;

    public AddressService()
    {
        _context = new SuperShopContext();
    }

    public AddressService(SuperShopContext context)
    {
        _context = context;
    }

    public void Create(Address entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
    }

    public Address GetById(int addressId)
    {
        return _context.Addresses.FirstOrDefault(a => a.Id == addressId);
    }

    public List<Address> GetEntitiesList()
    {
        return _context.Addresses.ToList();
    }

    public void Remove(Address address)
    {
        _context.Remove(address);
        _context.SaveChanges();
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}