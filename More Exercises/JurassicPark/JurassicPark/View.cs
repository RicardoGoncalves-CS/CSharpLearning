using JurassicPark.Management;
using JurassicPark.People.Visitors;

namespace JurassicPark;

public class View
{
    public static void Greetings()
    {
        Console.WriteLine("\u001b[32mWelcome to Jurassic Park!\u001b[0m");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.WriteLine();
    }

    public static void Farewell()
    {
        Console.WriteLine("\nThanks for your visit!");
        Console.WriteLine("Hope to see you back soon");
    }

    public static string MainMenu()
    {
        string choice = MenuGenerator.GenerateMenu(DataRegistery.menuOptions["Main menu"]);
        return choice;
    }

    public static string RegisterEmployeeMenu()
    {
        string choice = MenuGenerator.GenerateMenu(DataRegistery.menuOptions["Register new employee"]);
        return choice;
    }

    public static string RegisterVisitorMenu()
    {
        string choice = MenuGenerator.GenerateMenu(DataRegistery.menuOptions["Register new visitor"]);
        return choice;
    }
}