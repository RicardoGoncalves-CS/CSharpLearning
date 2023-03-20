using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.FileIO;
using System.Runtime.InteropServices;

namespace SQLWithCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONNECTING TO NORTHWIND DATABASE

            var connectioString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (var conn = new SqlConnection(connectioString))
            {
                conn.Open();

                Console.WriteLine(conn.State);

                Read(conn);
                // Create(conn);
                //Update(conn);
                Delete(conn);
            }

            void Read(SqlConnection conn)
            {
                using (var command = new SqlCommand("SELECT * FROM Customers;", conn))
                {
                    SqlDataReader sqlReader = command.ExecuteReader(); 
                    
                    while (sqlReader.Read())
                    {
                        Console.WriteLine(
                            $"Customer {sqlReader["ContactTitle"]} - {sqlReader["ContactName"]} " +
                            $"has ID {sqlReader["CustomerId"]} " +
                            $"and lives in {sqlReader["City"]}"
                            );
                    }
                    sqlReader.Close();
                }
            }

            void Create(SqlConnection conn)
            {
                string sql = $"INSERT INTO Customers(" +
                    $"CustomerID, ContactName, CompanyName, City" +
                    $") VALUES (" +
                    $"'WINDR', 'Phil Windridge', 'Birmingham', 'Sparta Global')"; 
                
                int affected; // Used to indicate if the operation was performed successfully; 1 indicates success
                
                using (var command = new SqlCommand(sql, conn))
                {
                    affected = command.ExecuteNonQuery();
                }
            }

            void Update(SqlConnection conn)
            {
                string sql = $"UPDATE Customers SET city = 'Berlin' WHERE CustomerID = 'WINDR';";

                int affected; 

                using (var command = new SqlCommand(sql, conn))
                {
                    affected = command.ExecuteNonQuery();
                }
            }

            void Delete(SqlConnection conn)
            {
                string sql = $"DELETE FROM Customers WHERE CustomerID = 'WINDR';";

                int affected;

                using (var command = new SqlCommand(sql, conn))
                {
                    affected = command.ExecuteNonQuery();
                }
            }
        }
    }
}