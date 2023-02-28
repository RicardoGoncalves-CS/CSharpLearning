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
        string greeting;

        if (timeOfDay >= 5 && timeOfDay <= 12)
        {
            greeting = "Good morning!";
        }
        else if (timeOfDay >= 12 && timeOfDay <= 18)
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