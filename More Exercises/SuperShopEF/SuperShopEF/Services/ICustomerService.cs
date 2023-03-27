using SuperShopData.Models;

namespace SuperShopData.Services;

public interface ICustomerService
{
    List<Customer> GetCustomersList();

    Customer GetCostumerById(int customerId);

    void CreateCustomer(Customer customer);

    void RemoveCustomer(Customer customer);

    void SaveCustomerChanges();
}
