namespace SuperShopData.Models;

public class OrderDetail
{
    public int Id { get; set; }

    public int Quantity { get; set; }

    public int ProductId { get; set; }

    public int OrderId { get; set; }

    // Relationships
    public Order order { get; set; } = null!;

    public Product product { get; set; } = null!;
}