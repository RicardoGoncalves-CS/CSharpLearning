[Go to the root folder](https://github.com/RicardoGoncalves-CS/Sparta)

# Week 5 Notes

1. [SQL in C#](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%205#sql-in-c)
2. [Object-Relational Mapping (ORM)](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%205#object-relational-mapping-orm)
3. [Entity Framework](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%205#entity-framework)
4. [LINQ](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%205#linq)
5. [LINQ Query Syntax](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%205#linq-query-syntax)
6. [LINQ Method Syntax](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%205#linq-method-syntax)
7. [Lambda Expressions](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%205#lambda-expression)
8. [Model-First approach for EntityFramework]()

### SQL in C#

Working with SQL in C# involves a number of key steps that enable you to interact with databases in your applications. Here are some of the important aspects of working with SQL in C#:

- Creating a database connection: The first step in working with SQL in C# is to establish a connection to the database. You can do this using the SqlConnection class from the Microsoft.Data.SqlClient namespace. You will need to provide a connection string that includes the server name, database name, and any authentication details necessary to connect to the database.
- Executing SQL commands: Once you have a database connection, you can use SqlCommand to execute SQL commands. This class has a number of methods for executing various types of commands, such as ExecuteNonQuery for commands that don't return data, ExecuteScalar for commands that return a single value, and ExecuteReader for commands that return a data set.
- Retrieving data: When executing a SQL command that returns data, you can use SqlDataReader to retrieve the results. This class allows you to read each row of data one at a time, and extract the values of each column. Alternatively, you can use SqlDataAdapter to fill a DataSet or DataTable with the results of a query.
- Handling errors: When working with databases, it's important to be prepared for errors such as invalid commands or lost connections. In C#, you can use try-catch blocks to handle exceptions that may occur when executing SQL commands. You should also ensure that you handle database errors appropriately, such as by displaying error messages to the user or logging errors for later analysis.
- Using best practices: To ensure that your code is efficient and secure, it's important to follow best practices when working with SQL in C#. This includes using parameterized queries to prevent SQL injection attacks, closing connections when you're done using them, and using stored procedures to encapsulate complex logic.

```C#
// Example of CRUD operations using SQL in C#
string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    Console.WriteLine(connection.State);

    // Each of the following commented methods execute the respective operation
    // ReadData(connection);
    // CreateData(connection);
    // UpdateData(connection);
    // DeleteData(connection);
}

void ReadData(SqlConnection connection)
{
    string sql = "SELECT * FROM Customers;";
    using (SqlCommand command = new SqlCommand(sql, connection))
    {
        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine($"Customer {reader["ContactTitle"]} - {reader["ContactName"]} " +
                                  $"has ID {reader["CustomerId"]} and lives in {reader["City"]}");
            }
        }
    }
}

void CreateData(SqlConnection connection)
{
    string sql = $"INSERT INTO Customers(" +
                 $"CustomerID, ContactName, CompanyName, City" +
                 $") VALUES (" +
                 $"'WINDR', 'Phil Windridge', 'Birmingham', 'Sparta Global')";

    using (SqlCommand command = new SqlCommand(sql, connection))
    {
        int rowsAffected = command.ExecuteNonQuery();
        if (rowsAffected > 0)
        {
            Console.WriteLine($"New row inserted successfully.");
        }
        else
        {
            Console.WriteLine($"Failed to insert new row.");
        }
    }
}

void UpdateData(SqlConnection connection)
{
    string sql = $"UPDATE Customers SET City = 'Berlin' WHERE CustomerID = 'WINDR';";

    using (SqlCommand command = new SqlCommand(sql, connection))
    {
        int rowsAffected = command.ExecuteNonQuery();
        if (rowsAffected > 0)
        {
            Console.WriteLine($"{rowsAffected} row(s) updated successfully.");
        }
        else
        {
            Console.WriteLine($"Failed to update row.");
        }
    }
}

void DeleteData(SqlConnection connection)
{
    string sql = $"DELETE FROM Customers WHERE CustomerID = 'WINDR';";

    using (SqlCommand command = new SqlCommand(sql, connection))
    {
        int rowsAffected = command.ExecuteNonQuery();
        if (rowsAffected > 0)
        {
            Console.WriteLine($"{rowsAffected} row(s) deleted successfully.");
        }
        else
        {
            Console.WriteLine($"Failed to delete row.");
        }
    }
}

```

### Object-Relational Mapping (ORM)

Object-Relational Mapping (ORM) is a technique used in software development to bridge the gap between object-oriented programming and relational databases. ORM frameworks provide a way to map database tables to classes in your code, allowing you to work with data in an object-oriented manner.

ORM frameworks are becoming increasingly popular in C# development, as they can simplify data access and reduce the amount of code required to interact with databases. Using an ORM, developers can work with data as objects, rather than having to write complex SQL queries.

Some of the key benefits of using an ORM in C# include:

- Reduced development time: By abstracting away the details of working with databases, ORM frameworks can significantly reduce the amount of code required to interact with databases, allowing developers to focus on other aspects of their applications.
- Improved maintainability: ORM frameworks provide a consistent and standardized way of working with databases, making it easier to maintain and update code over time.
- Object-oriented programming: ORM frameworks allow developers to work with data in an object-oriented manner, making it easier to write code that is more intuitive and easier to understand.
- Cross-platform support: Many ORM frameworks support multiple database platforms, making it easier to write code that can be run on different types of databases.

### Entity Framework

Entity Framework (EF) is an open-source Object-Relational Mapping (ORM) framework for .NET applications that allows developers to work with databases using .NET objects. It simplifies the process of querying and updating data in a database by allowing developers to work with database objects as .NET objects, without having to write SQL code.

Entity Framework is a part of the .NET Framework, and it supports multiple database providers including SQL Server, MySQL, Oracle, and SQLite. It is widely used in .NET application development due to its ease of use and flexibility.

Using Entity Framework in a C# application involves creating a DbContext class, which is responsible for managing the connection to the database and providing an interface for querying and updating data. The DbContext class includes a set of DbSet properties, which represent the tables in the database.

**Scaffold-DbContext** is a command in Entity Framework Core that generates entity classes and a DbContext class based on an existing database schema. It is a tool that automates the process of creating an Entity Framework model from an existing database.

When working with an existing database, developers can use Scaffold-DbContext to generate the code needed to work with the database tables and their corresponding entities in their C# application. This can save a significant amount of time and effort, as it eliminates the need for developers to manually create entity classes and mapping configurations for each table in the database.

To use Scaffold-DbContext, developers can open the Package Manager Console in Visual Studio and execute the command with the necessary parameters. For example, to generate a DbContext and entity classes for a SQL Server database named "MyDatabase", the following command could be used:

```C#
Scaffold-DbContext "Server=myServer;Database=MyDatabase;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```

This command would generate a DbContext class in a file named "MyDatabaseContext.cs" and entity classes for each table in the database, in the specified output directory.

Scaffold-DbContext is a powerful tool that can significantly simplify the process of working with existing databases in Entity Framework Core, and is a great way to get started with a new project that requires data access to an existing database.

```C#
// Example of operations using Entity Framework
using (var db = new NorthwindContext())
{
    var customer = new Customer
    {
        CustomerId = "BLOGG",
        ContactName = "Joe Bloggs",
        CompanyName = "ToysRUs",
        City = "Stoke-on-Trent"
    };

    db.Customers.Add(customer);                         // INSERT like command; Tracks object to be added to the database
    db.SaveChanges();                                   // Save the object to the database

    var selectedCustomer = db.Customers.Find("BLOGG");  // SELECT like command; Retrieve specified row from the db
    Console.WriteLine(selectedCustomer);

    selectedCustomer.City = "London";                   // UPDATE he city field of the specified row
    db.SaveChanges();

    db.Customers.Remove(selectedCustomer);              // DELETE the specified row
    db.SaveChanges();

    // NOTE: is necessary to use the SaveChanges() method to commit the changes
}
```

In C#, the using keyword is used to define a scope in which an object is used and to ensure that the object is disposed of properly when it is no longer needed.

In the the example above 'using (var db = new NorthwindContext())', creates a scope in which the db object is created and used. The db object is an instance of the NorthwindContext class, which is a DbContext class in Entity Framework that provides access to the underlying database.

When the code execution exits the scope of the using block, the Dispose() method of the db object is automatically called, which releases the resources used by the object, such as database connections, and ensures that any pending transactions are committed or rolled back. This helps to avoid issues like connection leaks, which can cause performance and stability problems.

Using the using statement with an object that implements the IDisposable interface is a common pattern in C# programming, and it is especially important when dealing with objects that use unmanaged resources, like database connections. By using the using statement, developers can ensure that the objects are disposed of correctly and efficiently, and avoid potential memory leaks and other issues.

### LINQ

LINQ (Language-Integrated Query) is a powerful feature in Microsoft's .NET Framework that provides a consistent, easy-to-use syntax for querying and manipulating data from various sources, such as databases, XML files, and collections of objects. It allows developers to write queries using familiar programming constructs, like loops and conditional statements, instead of learning a new query language for each type of data source.

LINQ provides a set of extension methods that can be applied to any object that implements the IEnumerable interface, which includes arrays, lists, and other collection types. These extension methods allow developers to perform operations like filtering, sorting, and grouping on the collection data using a simple and readable syntax.

For example, suppose you have a list of objects representing employees, and you want to find all the employees who have a salary greater than $50,000 and sort them by their last name. In LINQ, you can write this query using a combination of the Where() and OrderBy() extension methods, like this:

```C#
var highPaidEmployees = employees
    .Where(e => e.Salary > 50000)
    .OrderBy(e => e.LastName);
```

This query reads as "find all employees where their salary is greater than $50,000 and order them by their last name."

LINQ also supports projection, which allows developers to extract specific data from objects and return only the data they need. This can help reduce memory usage and improve performance by avoiding the creation of unnecessary objects.

### LINQ Query Syntax

LINQ supports a query syntax that allows developers to write queries that look more like SQL statements. Query syntax is often used for complex queries that involve multiple operations or when the query needs to be expressed more naturally.

The basic structure of a LINQ query in query syntax is as follows:

```C#
from variable in collection
[where condition]
[orderby property [, property2] [ascending|descending]]
[select property|object]
```

The **from** keyword introduces the source collection and the variable represents each element of the collection.

The **where** keyword is optional, and it specifies a condition that filters the elements based on a Boolean expression.

The **orderby** keyword is also optional and it sorts the elements in either ascending or descending order based on one or more properties.

Finally, the **select** keyword is used to specify the result of the query. It can be a single property of each element, or an entire new object that is created using a projection.

For example, the previous example using method syntax can be rewritten using query syntax as follows:

```C#
var highPaidEmployees = 
    from employee in employees
    where employee.Salary > 50000
    orderby employee.LastName
    select employee;
```

This query reads as "from the employees collection, select all the employees where their salary is greater than $50,000, order them by their last name, and return the entire employee object."

### LINQ Method Syntax

In LINQ, method syntax is the most common way of writing queries. It uses extension methods that are applied to collections to perform filtering, sorting, grouping, and projection operations on the data.

The basic structure of a LINQ query in method syntax is as follows:

```C#
collection.Operation1().Operation2().Operation3()...;
```

Each operation in the chain is an extension method that takes a collection as its first argument and returns a new collection with the operation performed on it.

For example, the following code snippet filters a list of numbers, sorts them in ascending order, and returns the first five numbers:

```C#
List<int> numbers = new List<int> { 10, 20, 5, 15, 30 };
var result = numbers.Where(n => n > 10).OrderBy(n => n).Take(5);
```

The **Where** extension method filters the numbers based on a condition that specifies that the number should be greater than 10. The OrderBy extension method sorts the resulting sequence in ascending order based on the numbers. The Take extension method then takes the first five numbers from the sorted sequence.

It is important to note that method syntax is more flexible and powerful than query syntax because it allows developers to chain together multiple operations in a single statement. It is also more efficient because the compiler can optimize the query execution by combining multiple operations into a single operation.

### Lambda Expressions

A lambda expression is a concise way to define an anonymous function in C#. It allows developers to define a small piece of code that can be passed as an argument to a method or used as a delegate.

The basic structure of a lambda expression is as follows:

```C#
(parameters) => expression
```

The parameters represent the input arguments to the lambda expression, and the expression represents the code that is executed when the lambda expression is called.

For example, the following lambda expression takes two integers as input and returns their sum:

```C#
(int a, int b) => a + b
```

Lambda expressions are commonly used in LINQ queries to define predicates, projections, and sorting operations. For example, the following code snippet filters a list of strings based on a condition that checks whether the string contains the letter 'a':

```C#
List<string> strings = new List<string> { "apple", "banana", "cherry" };
var result = strings.Where(s => s.Contains("a"));
```

The **Where** method takes a predicate as an argument, which is defined using a lambda expression that checks whether the string contains the letter 'a'.

Lambda expressions are also used to define anonymous delegates, which are used to pass a method as an argument to another method. For example, the following code snippet defines a lambda expression that is used as an argument to the List.ForEach method to print each item in the list:

```C#
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
numbers.ForEach(num => Console.WriteLine(num));
```

In this example, the lambda expression defines an anonymous delegate that takes an integer as an argument and prints it to the console.

### Model-First approach for EntityFramework

The **Model First** approach is an Object-Relational Mapping (ORM) technique that allows developers to create a new Entity Data Model (EDM) based on their application code without any existing database schema. This approach is ideal when developers want more control over the database schema and prefer to define the schema using code.

In the Model First approach, developers define the Entity Framework classes and mappings in code first, and then use Entity Framework to create the database schema based on the code. Developers can define the entities, their properties, relationships, and other details, such as constraints and indexes, using code.

Once the code is defined, developers can use the Entity Framework to interact with the database by querying and updating data using Entity Framework objects. The Entity Framework creates and manages the database schema, based on the code, and provides a higher-level abstraction of the database schema.

The Model First approach in Entity Framework provides several benefits, such as:

- Greater control: Developers have greater control over the database schema and can define it entirely in code, making it easier to manage and modify.
- Faster development: Developers can quickly create the Entity Framework code, without needing to design and create the database schema upfront.
- Easy customization: Developers can easily customize the Entity Framework classes and mappings to meet their specific requirements by adding business logic and customizations.
- Code-centric approach: Developers can focus on the code first and then let Entity Framework generate the database schema based on the code, reducing the amount of manual SQL scripting required.
- Database migration: Developers can easily update the database schema as the application evolves by generating SQL scripts that can update the database schema without data loss.

In summary, the Model First approach in Entity Framework is a great option for developers who want more control over the database schema and prefer to define it using code. It provides greater control, faster development, and easier customization capabilities.
