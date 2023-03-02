namespace Methods;

public class Program
{
    static void Main()
    {
        int result = SquarePlusOne(10);
        SayThisFeeling(feeling: "Energetic", day: "today"); // I can name the parameters which each value is assigned to

        bool successful = MyTryParse("One", out int number);

        Console.WriteLine($"My TryParse was successful ({successful})\nNumber is {number}");
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