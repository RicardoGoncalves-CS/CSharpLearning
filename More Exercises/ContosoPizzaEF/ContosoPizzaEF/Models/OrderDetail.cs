namespace ContosoPizzaEF.Models;

public class OrderDetail
{
    public int Id { get; set; }

    public int Quantity { get; set; }

    // ProductId and OrderId represent foreign keys
    public int ProductId { get; set; }

    public int OrderId { get; set; }

    // This class has navigation properties for both order and product
    public Order Order { get; set; } = null!;

    public Product Product { get; set; } = null!;
}