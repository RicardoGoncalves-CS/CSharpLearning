using System;
using System.Threading;
using System.Threading.Tasks;

namespace AysncCake
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to my birthday party");
            // await HaveAPartyAsync();
            HaveAPartyAsync();
            Console.WriteLine("Thanks for a lovely party");
            Console.ReadLine();
        }

        private static async Task HaveAPartyAsync() // Async method must include async in signature
        {
            var name = "Cathy";
            var cakeTask = BakeCakeAsync();
            PlayPartyGames();
            OpenPresents();
            //var cake = await cakeTask;  // body must include a await statement or use the line below
            var cake = cakeTask.Result; // forces the program to wait for the async task at this point
            Console.WriteLine($"Happy birthday, {name}, {cake}!!");
        }

        private static async Task<Cake> BakeCakeAsync() // We can use Task instead of Task<T> if we are returning a void
        {
            Console.WriteLine("Cake is in the oven");
            // Thread.Sleep(TimeSpan.FromSeconds(5));
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("Cake is done");
            return new Cake();
        }

        private static void PlayPartyGames()
        {
            Console.WriteLine("Starting games");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Finishing Games");
        }

        private static void OpenPresents()
        {
            Console.WriteLine("Opening Presents");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("Finished Opening Presents");
        }
    }

    public class Cake
    {
        public override string ToString()
        {
            return "Here's a cake";
        }
    }
}
