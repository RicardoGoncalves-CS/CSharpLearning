using JurassicPark.Factories;
using JurassicPark.People;
using JurassicPark.People.Employees;
using JurassicPark.People.Visitors;

namespace JurassicPark.Management;

internal static class Register
{
    internal static Identity id = new Identity();

    internal static bool successfulParse = false;
    internal static bool successfulValidation = false;

    internal static string emptyFieldMessage = "Field cannot be empty";

    internal static Visitor NewVisitor()
    {
        Console.Clear();

        Console.Write("Enter first name: ");
        id.FirstName = Console.ReadLine();

        Console.Write("Enter last name: ");
        id.LastName = Console.ReadLine();

        Console.Write("Enter nationality: ");
        id.Nationality = Console.ReadLine();

        do
        {
            Console.Write("Enter day of birth: ");
            successfulParse = int.TryParse(Console.ReadLine(), out int birthday);
            if(successfulParse) id.Birthday = birthday;
            else Console.WriteLine("Invalid value");
        } while (!successfulParse);

        do
        {
            Console.Write("Enter day of birth: ");
            successfulParse = int.TryParse(Console.ReadLine(), out int birthMonth);
            if (successfulParse) id.BirthMonth = birthMonth;
            else Console.WriteLine("Invalid value");
        } while (!successfulParse);

        do
        {
            Console.Write("Enter day of birth: ");
            successfulParse = int.TryParse(Console.ReadLine(), out int birthYear);
            if (successfulParse) id.BirthYear = birthYear;
            else Console.WriteLine("Invalid value");
        } while (!successfulParse);


        return PersonFactory.CreateVisitor(id.FirstName, id.LastName, id.Nationality, new DateOnly(id.BirthYear, id.BirthMonth, id.Birthday));
    }

    internal static void NewScientist()
    {
        Console.Clear();

        Console.WriteLine(">>> Scientist Registration");
        Console.WriteLine();

        do
        {
            Console.Write("Enter first name: ");
            id.FirstName = Console.ReadLine();
            if(id.FirstName == "") Console.WriteLine(emptyFieldMessage);
        } while (id.FirstName == "");

        do
        {
            Console.Write("Enter last name: ");
            id.LastName = Console.ReadLine();
            if (id.LastName == "") Console.WriteLine(emptyFieldMessage);
        } while (id.LastName == "");

        do
        {
            Console.Write("Enter nationality: ");
            id.Nationality = Console.ReadLine();
            if (id.Nationality == "") Console.WriteLine(emptyFieldMessage);
        } while (id.Nationality == "");

        do
        {
            do
            {
                Console.Write("Enter year of birth: ");
                successfulParse = int.TryParse(Console.ReadLine(), out int birthYear);
                successfulValidation = ValidateDate.isValidYear(birthYear);
                if (successfulParse)
                {
                    if (successfulValidation) 
                    {
                        id.BirthYear = birthYear;
                    } 
                    else Console.WriteLine("Invalid year");
                }
                else Console.WriteLine("Invalid value");
            } while (!successfulParse || !successfulValidation);

            do
            {
                Console.Write("Enter month of birth: ");
                successfulParse = int.TryParse(Console.ReadLine(), out int birthMonth);
                successfulValidation = ValidateDate.isValidMonth(birthMonth);
                if (successfulParse) 
                {
                    if (successfulValidation)
                    {
                        id.BirthMonth = birthMonth;
                    } 
                    else Console.WriteLine("Invalid month");
                }
                else Console.WriteLine("Invalid value");
            } while (!successfulParse || !successfulValidation);

            do
            {
                Console.Write("Enter day of birth: ");
                successfulParse = int.TryParse(Console.ReadLine(), out int birthday);
                successfulValidation = ValidateDate.IsValidDate($"{birthday}/{id.BirthMonth}/{id.BirthYear}");
                if (successfulParse) 
                {
                    if (successfulValidation) 
                    {
                        id.Birthday = birthday;
                    } 
                    else Console.WriteLine("Invalid day");
                } 
                else Console.WriteLine("Invalid value");
            } while (!successfulParse || !successfulValidation);
        } while (!ValidateDate.IsValidDate($"{id.Birthday}/{id.BirthMonth}/{id.BirthYear}"));

        DataRegistery.scientistsList.Add(PersonFactory.CreateScientist(id.FirstName, id.LastName, id.Nationality, new DateOnly(id.BirthYear, id.BirthMonth, id.Birthday)));
    }
}
