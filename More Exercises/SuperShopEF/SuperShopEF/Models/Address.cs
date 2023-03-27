using Microsoft.EntityFrameworkCore;

namespace SuperShopData.Models;

public class Address
{
    public int Id { get; set; }

    public string Number { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string City { get; set; } = null!;

    public string PostCode { get; set; } = null!;

    public string Country { get; set; } = null!;
}
