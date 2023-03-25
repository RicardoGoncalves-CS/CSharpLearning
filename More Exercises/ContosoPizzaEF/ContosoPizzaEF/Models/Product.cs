using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPizzaEF.Models;

public class Product
{
    // We can use Id or ClassId to name the primary key
    // We can also use any name by using the [Key] attribute
    public int Id { get; set; }

    // If we need to use a nullable type in our model but
    // don't want to have null stored in the database
    // we can use ? the type and the [Required] attribute
    public string Name { get; set; } = null!;

    // Price is a decimal with 2 points of precision
    [Column(TypeName = "decimal(6, 2)")]
    public decimal Price { get; set; }
}