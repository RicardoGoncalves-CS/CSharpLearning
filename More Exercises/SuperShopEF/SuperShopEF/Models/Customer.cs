namespace SuperShopData.Models;

public class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public Address? address { get; set; }

    public ICollection<Order> orders { get; set; } = null!;
}