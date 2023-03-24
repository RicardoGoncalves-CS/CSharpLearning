using System.Runtime.CompilerServices;

namespace DecoratorPattern;

internal class Program
{
    static void Main(string[] args)
    {

        // Decorator Pattern Examples
        IPizza pizza = new Pizza();
        Console.WriteLine(pizza.GetPizzaType());

        // Decorating pizza created above with cheese
        IPizza cheesePizza = new CheeseDecorator(pizza);
        Console.WriteLine(cheesePizza.GetPizzaType());

        // Creating a new pizza from the beginning with all decorators
        IPizza housePizza = new MushroomDecorator(
            new OnionDecorator(
                new CheeseDecorator(
                    new Pizza()
                    )
                )
            );

        Console.WriteLine(housePizza.GetPizzaType());
    }


    // base interface
    interface IPizza
    {

        string GetPizzaType();

    }


    // concrete class
    class Pizza : IPizza
    {

        public string GetPizzaType()
        {

            return "Pizza base";

        }

    }


    // base decorator
    class PizzaDecorator : IPizza
    {

        private IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {

            _pizza = pizza;

        }

        public virtual string GetPizzaType()
        {

            return _pizza.GetPizzaType();

        }

    }


    // concrete decorators
    class CheeseDecorator : PizzaDecorator
    {

        public CheeseDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {

            return base.GetPizzaType() + ", cheese";

        }

    }


    class OnionDecorator : PizzaDecorator
    {

        public OnionDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {

            return base.GetPizzaType() + ", onions";

        }

    }


    class MushroomDecorator : PizzaDecorator
    {

        public MushroomDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {

            return base.GetPizzaType() + ", mushrooms";

        }

    }

}