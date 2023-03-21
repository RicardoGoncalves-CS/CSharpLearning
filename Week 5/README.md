[Go to the root folder](https://github.com/RicardoGoncalves-CS/Sparta)

# Week 5 Notes

1. [SQL in C#](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%205#sql-in-c)
2. [Object-Relational Mapping (ORM)](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%205#object-relational-mapping-orm)
3. [Entity Framework](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%205#entity-framework)

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
