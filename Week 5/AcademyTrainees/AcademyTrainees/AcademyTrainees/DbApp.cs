using Azure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.IdentityModel.Tokens;

namespace AcademyTrainees;

public class DbApp
{
    private static bool _continue = true;
    public static void Run()
    {
        while (_continue)
        {
            int choice = TakeChoice();


            switch (choice)
            {
                case 1:
                    DbOperations.FindAll();
                    break;
                case 2:
                    DbOperations.Find();
                    break;
                case 3:
                    DbOperations.Add();
                    break;
                case 4:
                    DbOperations.Update();
                    break;
                case 5:
                    DbOperations.Delete();
                    break;
                default:
                    break;
            }
            AskContinue();
        }
    }
    private static void AskContinue()
    {
        Console.WriteLine("Continue? y/n");
        string resp = Console.ReadLine();

        if (resp.ToLower() == "n") _continue = false;
        else if (resp.ToLower() != "y")
        {
            Console.WriteLine("Invalid input");
            AskContinue();
        }
    }
    private static int TakeChoice()
    {
        string choice;
        int parsedChoice;

        Console.WriteLine("Enter the number of the operation to perform");
        Console.WriteLine("1. List all");
        Console.WriteLine("2. Find");
        Console.WriteLine("3. Add");
        Console.WriteLine("4. Update");
        Console.WriteLine("5. Remove");

        choice = Console.ReadLine();
        if (CheckChoice(choice, out parsedChoice) && parsedChoice <= 5 && parsedChoice >= 0) return parsedChoice;

        Console.WriteLine("Invalid Option");
        return TakeChoice();
    }

    private static bool CheckChoice(string choice, out int parsedChoice)
    {
        return Int32.TryParse(choice, out parsedChoice);
    }
}
