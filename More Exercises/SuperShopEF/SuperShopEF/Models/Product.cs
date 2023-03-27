using System.ComponentModel.DataAnnotations;

namespace SuperShopData.Models;

public class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    [Required]
    public int Price { get; set; }

    public Supplier supplier { get; set; } = null!;
}