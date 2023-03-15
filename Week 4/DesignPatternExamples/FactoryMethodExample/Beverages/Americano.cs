using FactoryMethodExample.DrinkShop;

namespace FactoryMethodExample.Beverages
{
    internal class Americano : Beverage
    {
        public override string Name => "Americano";

        public override void Prepare()
        {
            Console.WriteLine("Press the Americano button.. schhhhhhhhh gurgle.");
        }

        public override void Serve()
        {
            Console.WriteLine("Pass the Americano to the customer.");
        }
    }
}
