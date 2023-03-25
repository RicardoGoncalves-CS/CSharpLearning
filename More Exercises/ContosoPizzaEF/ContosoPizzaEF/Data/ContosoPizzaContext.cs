using Microsoft.EntityFrameworkCore;
using ContosoPizzaEF.Models;

namespace ContosoPizzaEF.Data;

// ContosoPizzaContext derives from DbContext
// DbContext represents a session with the database
internal class ContosoPizzaContext : DbContext
{
    // Each DbSet maps to a table created in the database
    public DbSet<Customer> Customers { get; set; } = null!;
    
    public DbSet<Product> Products { get; set; } = null!;
    
    public DbSet<Order> Orders { get; set; } = null!;
    
    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContosoPizza;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}
