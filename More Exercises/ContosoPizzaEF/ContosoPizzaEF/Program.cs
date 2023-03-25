using ContosoPizzaEF.Models;
using ContosoPizzaEF.Data;

namespace ContosoPizzaEF;

internal class Program
{
    static void Main(string[] args)
    {
        using ContosoPizzaContext context = new ContosoPizzaContext();
        {
            /* The commented code demonstrate the implementation 
             * of various operations such as adding to the database, 
             * reading from the database, updating information in 
             * the database and removing from the database
             */

            // Added veggieSpecial and Pepperoni to DB
            
            //Product veggieSpecial = new Product()
            //{
            //    Name = "Veggie Special Pizza",
            //    Price = 9.99M
            //};
            //context.Add(veggieSpecial);

            //Product Pepperoni = new Product()
            //{
            //    Name = "Pepperoni Pizza",
            //    Price = 9.99M
            //};
            //context.Add(Pepperoni);

            //context.SaveChanges();

            // Fluent APIs use method chain and lambda expressions to specify the query
            var products = context.Products
                .Where(p => p.Price < 10.00M)
                .OrderBy(p => p.Id);

            // Same query using LINQ syntax
            
            //var products = from product in context.Products
            //               where product.Price < 10.00M
            //               orderby product.Id
            //               select product;

            /* Changing the price of pizzas from 9.99 to 10.99
             * If the prices are changed we need to change the 
             * queries to show results
             */
            
            //var pizzas = context.Products
            //    .Where(p => p.Price == 9.99M);

            //foreach(var p in pizzas)
            //{
            //    if (p is Product) p.Price = 10.99M;
            //}

            foreach(var p in products)
            {
                Console.WriteLine($"Id:     {p.Id}");
                Console.WriteLine($"Name:   {p.Name}");
                Console.WriteLine($"Price:  {p.Price}");
                Console.WriteLine(new string('-', 30));
            }

            /* To delete we just need to pass a reference to
             * the entity to the remove function on the db context
             */

            //var pepperoni = context.Products
            //    .Where(p => p.Name == "Veggie Special Pizza")
            //    .FirstOrDefault();

            //if (pepperoni is Product) context.Remove(pepperoni);
        }
    }
}