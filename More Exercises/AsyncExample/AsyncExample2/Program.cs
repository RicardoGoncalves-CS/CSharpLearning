using System.Diagnostics;

namespace AsyncExample2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            await PrepareBreakfast();
            Console.WriteLine("Breakfast is ready");
            sw.Stop();
            Console.WriteLine($"Breakfast took {sw.ElapsedMilliseconds} ms to prepare");
        }

        public static void PrepareBread()
        {
            Console.WriteLine("Cut the bread open");
            Console.WriteLine("Spread butter on the bread");
        }

        public static void PrepareCup()
        {
            Console.WriteLine("The cup is ready for the tea");
        }

        /* We can observe that both cookBacon and brewTea tasks take wait 4 seconds
         * to complete which they will process in parallel;
         */
        public static async Task PrepareBreakfast()
        {
            var cookBacon = CookBaconAsync();
            PrepareCup();
            var brewTea = TeaBrewAsync();
            PrepareBread();
            var bacon = await cookBacon;
            Console.WriteLine(bacon.IsCooked());
            var tea = await brewTea;
            Console.WriteLine(tea.IsBrewed());
        }

        public static async Task<Bacon> CookBaconAsync()
        {
            Console.WriteLine("Bacon is in the oven");
            await Task.Delay(TimeSpan.FromSeconds(4));
            return new Bacon();
        }

        public static async Task<Tea> TeaBrewAsync()
        {
            Console.WriteLine("Tea is brewing");
            await Task.Delay(TimeSpan.FromSeconds(4));
            return new Tea();
        }
    }

    public class Bacon
    {
        public string IsCooked()
        {
            return "Bacon is cooked";
        }
    }

    public class Tea
    {
        public string IsBrewed()
        {
            return "Tea is brewed";
        }
    }
}