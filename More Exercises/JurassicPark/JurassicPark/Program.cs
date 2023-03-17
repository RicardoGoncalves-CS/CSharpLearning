using JurassicPark.Factories;
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

        Scientist testScientist = PersonFactory.CreateScientist("Alan", "Grant");
        Console.WriteLine($"{testScientist}; Full name: {testScientist.GetFullName()}; Nationality: {testScientist.id.Nationality}; DoB: {testScientist.GetDateOfBirth()};");
        Console.WriteLine();

        Visitor testVisitor = PersonFactory.CreateVisitor("William", "Wallace", "Scotland");
        Console.WriteLine($"{testVisitor}; Full name: {testVisitor.GetFullName()}; Nationality: {testVisitor.id.Nationality}; DoB: {testVisitor.GetDateOfBirth()};");
        Console.WriteLine();

        Visitor testEmployee = PersonFactory.CreateVisitor("Walter", "White", "American", new DateOnly(1978, 9, 17));
        Console.WriteLine($"{testEmployee}; Full name: {testEmployee.GetFullName()}; Nationality: {testEmployee.id.Nationality}; DoB: {testEmployee.GetDateOfBirth()};");
        Console.WriteLine();

        Controller.Start();
    }
}