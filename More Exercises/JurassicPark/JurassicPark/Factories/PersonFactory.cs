using JurassicPark.People;
using JurassicPark.People.Employees;
using JurassicPark.People.Visitors;

namespace JurassicPark.Factories;

public static class PersonFactory
{
    internal static Visitor CreateVisitor(string firstName, string lastName)
    {
        return new Visitor() { id = new Identity { FirstName = firstName, LastName = lastName } };
    }

    internal static Visitor CreateVisitor(string firstName, string lastName, string nationality)
    {
        return new Visitor() { id = new Identity { FirstName = firstName, LastName = lastName, Nationality = nationality } };
    }

    internal static Visitor CreateVisitor(string firstName, string lastName, DateOnly dob)
    {
        return new Visitor() { id = new Identity { FirstName = firstName, LastName = lastName, Birthday = dob.Day, BirthMonth = dob.Month, BirthYear = dob.Year } };
    }

    internal static Visitor CreateVisitor(string firstName, string lastName, string nationality, DateOnly dob)
    {
        return new Visitor() { id = new Identity { FirstName = firstName, LastName = lastName, Nationality = nationality, Birthday = dob.Day, BirthMonth = dob.Month, BirthYear = dob.Year } };
    }

    // Overload the CreateEmployee method to include the department and salary
    internal static Employee CreateEmployee(string firstName, string lastName)
    {
        return new Employee() { id = new Identity { FirstName = firstName, LastName = lastName } };
    }

    internal static Employee CreateEmployee(string firstName, string lastName, string nationality)
    {
        return new Employee() { id = new Identity { FirstName = firstName, LastName = lastName, Nationality = nationality } };
    }

    internal static Employee CreateEmployee(string firstName, string lastName, DateOnly dob)
    {
        return new Employee() { id = new Identity { FirstName = firstName, LastName = lastName, Birthday = dob.Day, BirthMonth = dob.Month, BirthYear = dob.Year } };
    }

    internal static Employee CreateEmployee(string firstName, string lastName, string nationality, DateOnly dob)
    {
        return new Employee() { id = new Identity { FirstName = firstName, LastName = lastName, Nationality = nationality, Birthday = dob.Day, BirthMonth = dob.Month, BirthYear = dob.Year } };
    }

    internal static Employee CreateEmployee(string firstName, string lastName, string department, decimal salary)
    {
        return new Employee() { id = new Identity { FirstName = firstName, LastName = lastName }, Department = department, Salary = salary };
    }

    // Overload the CreateScientist method to include the department and salary
    internal static Scientist CreateScientist(string firstName, string lastName)
    {
        return new Scientist() { id = new Identity { FirstName = firstName, LastName = lastName } };
    }

    internal static Scientist CreateScientist(string firstName, string lastName, string nationality)
    {
        return new Scientist() { id = new Identity { FirstName = firstName, LastName = lastName, Nationality = nationality } };
    }

    internal static Scientist CreateScientist(string firstName, string lastName, DateOnly dob)
    {
        return new Scientist() { id = new Identity { FirstName = firstName, LastName = lastName, Birthday = dob.Day, BirthMonth = dob.Month, BirthYear = dob.Year } };
    }

    internal static Scientist CreateScientist(string firstName, string lastName, string nationality, DateOnly dob)
    {
        return new Scientist() { id = new Identity { FirstName = firstName, LastName = lastName, Nationality = nationality, Birthday = dob.Day, BirthMonth = dob.Month, BirthYear = dob.Year } };
    }

    internal static Scientist CreateScientist(string firstName, string lastName, string department, decimal salary)
    {
        return new Scientist() { id = new Identity { FirstName = firstName, LastName = lastName }, Department = department, Salary = salary };
    }
}