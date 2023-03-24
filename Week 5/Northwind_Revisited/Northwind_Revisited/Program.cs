using Microsoft.EntityFrameworkCore;
using Northwind_Revisited.Models;

namespace Northwind_Revisited
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                // 1.1 Write a query that lists all Customers in either Paris or London. Include Customer ID, Company Name and all address fields.

                var q1_1 = db.Customers
                    .Where(c => c.City == "London" || c.City == "Paris");

                Console.WriteLine("1.1");
                foreach (var row in q1_1)
                {
                    Console.WriteLine($"{row.CustomerId} - {row.CompanyName} - {row.Address} {row.PostalCode} {row.City} {row.Country}");
                }




                // 1.2 List all products stored in bottles.
                Console.WriteLine();

                var q1_2 = db.Products
                    .Where(p => p.QuantityPerUnit.Contains("bottle"));

                Console.WriteLine("1.2");
                foreach (var row in q1_2)
                {
                    Console.WriteLine($"{row.ProductName} - {row.QuantityPerUnit}");
                }




                // 1.3 Repeat question above, but add in the Supplier Name and Country.
                Console.WriteLine();

                var q1_3 = db.Products
                    .Join(
                    db.Suppliers,
                    p => p.SupplierId,
                    s => s.SupplierId,
                    (p, s) => new
                    {
                        pName = p.ProductName,
                        pQuantity = p.QuantityPerUnit,
                        sName = s.CompanyName,
                        sCountry = s.Country
                    }
                    )
                    .Where(p => p.pQuantity.Contains("bottle"));

                Console.WriteLine("1.3");
                foreach (var row in q1_3)
                {
                    Console.WriteLine($"Product: {row.pName} - {row.pQuantity}; Supplier: {row.sName} - {row.sCountry}");
                }




                // 1.4 Write a method that shows how many products there are in each category. Include Category Name in result set and list the highest number first.
                Console.WriteLine();

                var q1_4 = db.Products
                    .GroupBy(p => p.Category.CategoryName)
                    .Select(g => new
                    {
                        catName = g.Key,
                        count = g.Count()
                    })
                    .OrderByDescending(c => c.count);

                Console.WriteLine("1.4");
                foreach (var row in q1_4)
                {
                    Console.WriteLine($"{row.catName}: {row.count}");
                }




                // 1.5 List all UK employees using concatenation to join their titleofcourtesy, first name and last name together. Also include their city of residence.
                Console.WriteLine();

                var q1_5 = db.Employees
                    .Where(e => e.Country == "UK")
                    .Select(e => new
                    {
                        title = e.TitleOfCourtesy,
                        fName = e.FirstName,
                        lName = e.LastName,
                        city = e.City
                    });

                Console.WriteLine("1.5");
                foreach (var row in q1_5)
                {
                    Console.WriteLine(row.title + " " + row.fName + " " + row.lName + ", " + row.city);
                }




                // 1.6 Count how many Orders have a Freight amount greater than 100.00 and either USA or UK as Ship Country.
                Console.WriteLine();

                var q1_6 = db.Orders
                    .Where(o => o.Freight > 100 && (o.ShipCountry == "UK" || o.ShipCountry == "USA"))
                    .Count();

                Console.WriteLine("1.6");
                Console.WriteLine($"Total count: {q1_6}");
            }
        }
    }
}