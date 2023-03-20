using Northwind_data.Models;

namespace Northwind_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                // Console.WriteLine(db.ContextId);

                //foreach(var customer in db.Customers)
                //{
                //    Console.WriteLine(customer);
                //}

                var customer = new Customer
                {
                    CustomerId = "BLOGG",
                    ContactName = "Joe Bloggs",
                    CompanyName = "ToysRUs",
                    City = "Stoke-on-Trent"
                };

                //db.Customers.Add(customer); // Tracks object to be added to the database
                //db.SaveChanges();           // Save the object to the database

                var selectedCustomer = db.Customers.Find("BLOGG");
                Console.WriteLine(selectedCustomer);

                selectedCustomer.City = "London"; // UPDATE
                db.SaveChanges();

                selectedCustomer = db.Customers.Find("BLOGG");
                Console.WriteLine(selectedCustomer);

                db.Customers.Remove(selectedCustomer);  // DELETE
                db.SaveChanges();

                selectedCustomer = db.Customers.Find("BLOGG");
                Console.WriteLine(selectedCustomer);
            }
        }
    }
}