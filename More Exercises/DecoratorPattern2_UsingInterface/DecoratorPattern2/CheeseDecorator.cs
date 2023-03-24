namespace DecoratorPattern2;

internal class CheeseDecorator : SandwichDecorator
{

    public CheeseDecorator(ISandwich sandwich) : base(sandwich) { }

    public override string Description() => base.Description() + ", cheese";

    public override decimal Price() => base.Price() + 0.3m;

}