namespace AsyncExample4;

internal class Program
{
    static async Task Main()
    {
        var result = await MakeTeaAsync();
        Console.WriteLine(result);
    }

    // Async methods
    public static async Task<string> MakeTeaAsync()
    {
        var boilingWater = BoilWaterAsync();

        Console.WriteLine("Take the cups out");

        Console.WriteLine("Put tea in cups");

        var water = await boilingWater;

        var tea = $"Pour {water} in cups";

        return tea;
    }

    public static async Task<string> BoilWaterAsync()
    {
        Console.WriteLine("Start the kettle");

        Console.WriteLine("Waiting for the kettle");
        await Task.Delay(2000);

        Console.WriteLine("Kettle finished boiling water");

        return "water";
    }

    // Not Async
    public static string MakeTea()
    {
        var water = BoilWater();

        Console.WriteLine("Take the cups out");

        Console.WriteLine("Put tea in cups");

        var tea = $"Pour {water} in cups";

        return tea;
    }

    public static string BoilWater()
    {
        Console.WriteLine("Start the kettle");

        Console.WriteLine("Waiting for the kettle");
        Task.Delay(2000).GetAwaiter().GetResult();

        Console.WriteLine("Kettle finished boiling water");

        return "water";
    }
}