[Go to the root folder](https://github.com/RicardoGoncalves-CS/Sparta)

# Week 5 Notes

1. [SQL in C#]()
2. []

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
