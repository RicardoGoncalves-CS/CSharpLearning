namespace StatePatternExample;

internal class Program
{
    static void Main(string[] args)
    {
        Computer pc = new Computer();

        Console.WriteLine("Computer charger is plugged in");

        pc.PressPowerButton();
        Console.WriteLine(pc.message);

        pc.PressPowerButton();
        Console.WriteLine(pc.message);

        pc.PressPowerButton();
        Console.WriteLine(pc.message);

        pc.UnplugCharger();
        Console.WriteLine("Computer charger is plugged off");

        pc.PressPowerButton();
        Console.WriteLine(pc.message);

        pc.PressPowerButton();
        Console.WriteLine(pc.message);
    }
}