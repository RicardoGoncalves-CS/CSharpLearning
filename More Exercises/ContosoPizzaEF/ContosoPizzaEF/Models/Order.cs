namespace ContosoPizzaEF.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderPlaced { get; set; }

        public DateTime? OrderFulfilled { get; set; }

        // This represents a Foreign key to the Customer table
        public int CustomerId { get; set; }


        // This is a navigation property specifying one customer per order
        // This creates a one to one relationship in the DB
        public Customer customer { get; set; } = null!;

        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}