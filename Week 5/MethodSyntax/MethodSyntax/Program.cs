using MethodSyntax.Models;

using (var db = new NorthwindContext())
{
    var querySyntax =
        from c in db.Customers
        where c.City == "London"
        orderby c.ContactName
        select c;

    var methodSyntax = db.Customers
        .Where(c => c.City == "London")
        .OrderBy(c => c.ContactName);

    // Lamba expressions
    // c => c * c
    // c => { c * c }
    // (c, d) => { c * d }

    // Using Lambda expressions
    var nums = new List<int> { 3, 7, 1, 2, 8, 3, 0, 4, 5 };
    Console.WriteLine(nums.Count(num => num % 2 == 0));
    Console.WriteLine(nums.Count(num => num % 2 != 0));
    Console.WriteLine(nums.Count(num => num <= 4));

    var nums2 = new List<int> { 3, 7, 1, 2, 8, 3, 0, 4, 5 };
    // Using delegate
    Console.WriteLine(nums.Count(delegate (int num) { return num % 2 == 0; }));
    // Passing a function as parameter
    Console.WriteLine(nums.Count(IsOdd));
    // Using Lambda expression
    Console.WriteLine(nums.Count(delegate (int num) { return num <= 4; }));

    Console.WriteLine("--------------------------");

    // CONTINUE NORTHWIND EXERCISES
    var customersInLondon = db.Customers
        .Count(c => c.City == "London" || c.City == "Berlin");

    Console.WriteLine("--------------------------");

    // Find all customers with ContactName starting in 'A'
    var customersStartingWithA = db.Customers
        .Where(c => c.ContactName.StartsWith("A"));

    foreach (var customer in customersStartingWithA)
    {
        Console.WriteLine($"{customer.ContactName}");
    }

    Console.WriteLine("--------------------------");

    // Group UnitsInStock by SupplierId
    var groupBySupplierId = db.Products
        .GroupBy(c => c.SupplierId)
        .Select(g => new
        {
            supId = g.Key,
            unitsInStock = g.Sum(p => p.UnitsInStock)
        });

    foreach(var group in groupBySupplierId)
    {
        Console.WriteLine($"{group.supId} - {group.unitsInStock}");
    }

    Console.WriteLine("--------------------------");

    // Order Products by QuantityPerUnit (which by default will be in ascending order), then in descending order of ReorderLevel.
    var orderByQuantity = db.Products
        .OrderBy(p => p.QuantityPerUnit)
        .ThenByDescending(p => p.ReorderLevel);

    foreach(var prod in orderByQuantity)
    {
        Console.WriteLine($"{prod.QuantityPerUnit} - {prod.ReorderLevel}");
    }
}

static bool IsOdd(int num)
{
    return num % 2 != 0;
}