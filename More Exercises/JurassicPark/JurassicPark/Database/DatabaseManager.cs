using System.Data.SqlClient;

namespace JurassicPark.Database;

internal class DatabaseManager
{
    public static void connector()
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\RICAR\SPARTAGIT\MORE EXERCISES\JURASSICPARK\JURASSICPARK\DATABASE\JURASSICPARK.MDF;Integrated Security=True;";
        SqlConnection con = new SqlConnection(connectionString);
        {
            con.Open();
            Console.WriteLine("Connection opened successfully.");
        }
    }
}
