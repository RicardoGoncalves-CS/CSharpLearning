namespace UnitTestApp;

public class Program
{
    static void Main()
    {
        int timeOfDay = 21;
        if (timeOfDay >= 5 && timeOfDay <= 12)
        {
            Console.WriteLine("Good morning!");
        }
        else if (timeOfDay >= 12 && timeOfDay <= 18)
        {
            Console.WriteLine("Good afternoon!");
        }
        else
        {
            Console.WriteLine("Good evening!");
        }
    }
}