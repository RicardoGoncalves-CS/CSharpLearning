using SuperShopBusiness.TablesManagers;
using SuperShopData.Models;

namespace SuperShopBusiness;

internal class Program
{
    static void Main(string[] args)
    {
        Address address = new Address 
        { 
            Number = "10", 
            Street = "New Street", 
            City = "Birmingham", 
            PostCode = "B10 2AB", 
            Country = "UK" 
        };

        CustomerManager cm = new CustomerManager();
        AddressManager am = new AddressManager();

        am.Delete(1);
        //cm.Create("Alan", "Grant", "07123412123", "grantalan@mail.com", address);

    }
}