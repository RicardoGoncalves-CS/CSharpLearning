using DecoratorPattern3.Decorators;

namespace DecoratorPattern3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car baseCar = new Audi();

            Console.WriteLine($"Car 1: {baseCar.Description()} has a maximum speed of {baseCar.Speed()}km/ph and costs {baseCar.Price():C}");


            Car SportCar =
                new SportTyresDecorator(
                    new SportEngineDecorator(
                        new Audi()));

            Console.WriteLine($"Car 2: {SportCar.Description()} has a maximum speed of {SportCar.Speed()}km/ph and costs {SportCar.Price():C}");


            Car FullOptionsCar =
                new PremiumInteriorDecorator(
                    new SportTyresDecorator(
                        new SportEngineDecorator(
                            new Audi())));

            Console.WriteLine($"Car 3: {FullOptionsCar.Description()} has a maximum speed of {FullOptionsCar.Speed()}km/ph and costs {FullOptionsCar.Price():C}");

        }
    }
}