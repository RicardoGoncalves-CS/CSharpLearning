namespace UnitTestApp;

public class Program
{
    static void Main()
    {
        int inputValue = Int32.Parse(Console.ReadLine());
        string output = MyMethod(inputValue);
        Console.WriteLine(output);
    }

    public static string MyMethod(int timeOfDay)
    {
        /*
        Assuming timeOfDay is valid and 0-23 we should create 3 tests for each band
        Band1 = 0-5
        Band2 = 5-12
        Band3 = 12-18
        Band4 = 18-23
        */

        string greeting;

        if (timeOfDay < 5)
        {
            greeting = "Good morning!";
        }
        else if (timeOfDay < 12)
        {
            greeting = "Good morning!";
        }
        else if (timeOfDay <= 18)
        {
            greeting = "Good afternoon!";
        }
        else
        {
            greeting = "Good evening!";
        }

        return greeting;
    }
}