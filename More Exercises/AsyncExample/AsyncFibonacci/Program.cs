namespace AsyncFibonacci;

internal class Program
{
    public static async Task Main(string[] args)
    {
        var calculator = new FibonacciCalculator();

        Console.WriteLine("Enter a number to calculate its Fibonacci number:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Calculating Fibonacci({n})...");

        long result = await calculator.CalculateAsync(n);

        Console.WriteLine($"Fibonacci({n}) = {result}");
    }
}


public class FibonacciCalculator
{
    public async Task<long> CalculateAsync(int n)
    {
        Console.WriteLine("This might take a while");

        return await Task.Run(() =>
        {
            return Fibonacci(n);
        });
    }

    private long Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}