using JurassicPark.People.Employees;
using JurassicPark.People.Visitors;
using System.Data.SqlClient;

namespace JurassicPark;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Jurassic Park!");
        Console.WriteLine();

        Visitor firstVisitor = new Visitor("John", "Smith");

        Console.WriteLine($"{firstVisitor}; Full name: {firstVisitor.GetFullName()}; Nationality: {firstVisitor.id.Nationality}; DoB: {firstVisitor.GetDateOfBirth()};");
        Console.WriteLine();

        Console.WriteLine($"Updating information on {firstVisitor}");

        firstVisitor.id.Nationality = "English";
        firstVisitor.SetDateOfBirth(new DateOnly(1982, 4, 10));

        Console.WriteLine($"{firstVisitor}; Full name: {firstVisitor.GetFullName()}; Nationality: {firstVisitor.id.Nationality}; DoB: {firstVisitor.GetDateOfBirth()};");
        Console.WriteLine();

        Scientist firstScientist = new Scientist("Alan", "Grant", "American", new DateOnly(1978, 8, 22));
        Console.WriteLine($"{firstScientist}; Full name: {firstScientist.GetFullName()}; Nationality: {firstScientist.id.Nationality}; DoB: {firstScientist.GetDateOfBirth()};");
        Console.WriteLine();

        connector();
    }

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