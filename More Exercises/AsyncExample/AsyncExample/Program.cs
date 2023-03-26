using System.Diagnostics;
using System.Net;

namespace AsyncExample;

internal class Program
{
    static void Main()
    {
        Blocking();
        Console.WriteLine();

        // Without the Sleep method the console app would finish before the results of the async operations are resolved
        WithCallBack();
        Thread.Sleep(2000);
        Console.WriteLine();

        WithAsync();
        Console.WriteLine("Doing something in the meantime...");
        Thread.Sleep(2000);
        Console.WriteLine();
    }


    private static void ReportThread()
    {
        Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
    }


    // Without ast=ynchronous operations
    private static void Blocking()
    {
        WebClient client = new WebClient();

        Console.WriteLine("Starting call...");

        ReportThread();

        var stream = client.OpenRead(new Uri("https://bcc.co.uk"));

        ReportThread();

        Console.WriteLine("Results in...");

        Console.WriteLine(new StreamReader(stream).ReadLine());
    }
    

    // With Callback we created a new function to handle the StreamReader
    private static void WithCallBack()
    {
        Stopwatch sw = new Stopwatch();

        WebClient client = new WebClient();

        client.OpenReadCompleted += Client_OpenReadCompleted;

        Console.WriteLine("Starting call...");

        ReportThread();

        client.OpenReadAsync(new Uri("https://bcc.co.uk"));

        Console.WriteLine("Doing something in the meantime...");
    }

    private static void Client_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
    {
        Console.WriteLine("Results in...");

        ReportThread();

        Console.WriteLine(new StreamReader(e.Result).ReadLine());

        
    }
    

    // With and Async method
    private static async void WithAsync()
    {
        WebClient client = new WebClient();

        Console.WriteLine("Starting call...");

        ReportThread();

        var stream = await client.OpenReadTaskAsync(new Uri("https://bcc.co.uk"));

        ReportThread();

        Console.WriteLine("Results in...");

        Console.WriteLine(new StreamReader(stream).ReadLine());
    }
}