namespace JurassicPark;

public class View
{
    public static void Greetings()
    {
        Console.WriteLine("Welcome to Jurassic Park!");
        Console.WriteLine();
    }

    public static string MainMenu()
    {
        int inputChoice = -1;
        bool successfulParsed = false;

        Dictionary<int, string> options = new Dictionary<int, string>() { { 0, "quit" }, { 1, "register" } };
        
        Console.WriteLine("============ MAIN MENU ============");
        Console.WriteLine("Select an option to proceed");
        Console.WriteLine("1: Register new person");
        Console.WriteLine("0: Quit");
        Console.WriteLine("===================================");
        while(!successfulParsed || !options.ContainsKey(inputChoice))
        {
            Console.Write(">> ");
            successfulParsed = int.TryParse(Console.ReadLine(), out inputChoice);
            if (options.ContainsKey(inputChoice))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid option");
                Console.WriteLine();
            }
        }
        return options[inputChoice];
    }

    public static void RegisteryMenu()
    {
        int inputChoice = -1;
        bool successfulParsed = false;

        Dictionary<int, string> options = new Dictionary<int, string>() { { 0, "quit" }, { 1, "scientist" } };

        Console.Clear();

        Console.WriteLine("========== REGISTER MENU ==========");
        Console.WriteLine("Select an option to proceed");
        Console.WriteLine("1: Register new Scientist");
        Console.WriteLine("0: Quit");
        Console.WriteLine("===================================");

        while (!successfulParsed || !options.ContainsKey(inputChoice))
        {
            Console.Write(">> ");
            successfulParsed = int.TryParse(Console.ReadLine(), out inputChoice);
            if (options.ContainsKey(inputChoice))
            {
                Console.WriteLine("Valid option");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid option");
                Console.WriteLine();
            }
        }
    }
}
