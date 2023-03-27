namespace SuperShopData.Models;

public class Order
{
    public int Id { get; set; }

    public DateTime orderPlaced { get; set; }

    public DateTime orderFulfilled { get; set; }

    public int CustomerId { get; set; }

    // Relationships
    public Customer customer { get; set; } = null!;

    public ICollection<OrderDetail> orderDetails { get; set; } = null!;
}