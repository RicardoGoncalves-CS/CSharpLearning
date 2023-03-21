using QuerySyntax.Models;
using System.Runtime.Versioning;

namespace QuerySyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                // Query
                var records =
                    from customer in db.Customers // db.Customers is out data source
                    where customer.City == "London" || customer.City == "Berlin"
                    orderby customer.ContactName descending // Ordering by contact name in descending order
                    select customer;
                    //select new  // Anonymous type (public, read-only)
                    //{
                    //    Customer = customer.CompanyName,
                    //    Country = customer.Country
                    //};

                // Query execution
                foreach(var row in records)
                {
                    Console.WriteLine(row);
                }

                Console.WriteLine("-------------------------------------------------");

                // Query2
                var records2 =
                  from product in db.Products
                  group product by product.SupplierId into newGroup
                  orderby newGroup.Sum(c => c.UnitsInStock) descending
                  select new
                  {
                      SupplierId = newGroup.Key,
                      UnitsInStock = newGroup.Sum(c => c.UnitsInStock)
                  };

                foreach(var row in records2)
                {
                    Console.WriteLine(row);
                }
            }
        }
    }
}