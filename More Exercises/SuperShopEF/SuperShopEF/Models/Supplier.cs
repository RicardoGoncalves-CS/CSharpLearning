namespace SuperShopData.Models;

public class Supplier
{
    public int Id { get; set; }

    public string CompanyName { get; set; } = null!;

    public string ContactName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public Address address { get; set; } = null!;
}