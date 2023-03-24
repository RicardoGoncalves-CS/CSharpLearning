namespace DecoratorPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ISandwich mySandwich =
                new CheeseDecorator(
                    new Sandwich()
                );

            ISandwich sandwich2 =
                new CheeseDecorator(
                    new HamDecorator(
                        new TomatoesDecorator(
                            new LettuceDecorator(
                                new EggDecorator(
                                    new Sandwich()
                                )
                            )
                        )
                    )
                );


            Console.WriteLine("Sandwich 1:");
            Console.WriteLine($"{mySandwich.Description()} sandwich costs {mySandwich.Price():C}\n");

            Console.WriteLine("Sandwich 2:");
            Console.WriteLine($"{sandwich2.Description()} sandwich costs {sandwich2.Price():C}\n");

        }
    }
}