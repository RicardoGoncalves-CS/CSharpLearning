using JurassicPark.People.Employees;
using JurassicPark.People.Visitors;

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
    }
}