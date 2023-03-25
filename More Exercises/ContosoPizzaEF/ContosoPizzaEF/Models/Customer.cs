namespace ContosoPizzaEF.Models;

public class Customer
{
    public int Id { get; set; }

    // FirstName and LastName shouldn't allow null in the DB
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    // Address and Phone should allow null in the DB
    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }


    // This is a navigation property and indicates that
    // a customer has zero or more orders.
    // This creates a one to many relationship in the DB
    public ICollection<Order> Orders { get; set; } = null!;
}