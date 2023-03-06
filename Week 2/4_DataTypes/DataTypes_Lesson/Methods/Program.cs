using System.Net.Cache;

namespace Methods;

public class Program
{
    static void Main()
    {
        int result = SquarePlusOne(10);
        SayThisFeeling(feeling: "Energetic", day: "today"); // I can name the parameters which each value is assigned to

        // Out variables and Tuples
        bool successful = MyTryParse("One", out int number);

        Console.WriteLine($"My TryParse was successful ({successful})\nNumber is {number}");

        var myTuple = ("Samson", "Cross", 25);
        Console.WriteLine($"{myTuple.Item1} is {myTuple.Item3}");

        var namedTuple = (FirstName: "Luke", LastName: "Pinder", Age: 20);
        Console.WriteLine($"{namedTuple.FirstName} is {namedTuple.Age}");
    }

    private static bool MyTryParse(string input, out int num)
    {
        try
        {
            num = Int32.Parse(input);
            return true;
        }
        catch (Exception e)
        {
            num = 404;
            return false;
        }
    }

    private static int SquarePlusOne(int num)
    {
        return num * num + 1;
    }

    private static void SayThisFeeling(string day, string feeling = "Happy") // = "Happy" is a default value; Required arguments should come first
    {
        Console.WriteLine($"I'm feeling {feeling} {day}");
    }

    // Tuple type Methods
    private static (int pounds, int stones) PoundsToStones(int pounds)
    {
        return (pounds % 14, pounds / 14);
    }

    private static string MakePizza(bool pepperoni = true, bool pineapple = false, bool ham = false, bool mushrooms = true, bool olives = true, bool peppers = true)
    {
        string pizza = "Your pizza has ";

        if (pepperoni) pizza += "pepperoni ";
        if (pineapple) pizza += "pineapple ";
        if (ham) pizza += "ham ";
        if (mushrooms) pizza += "mushrooms ";
        if (olives) pizza += "olives ";

        return pizza;
    }
}