namespace DecoratorPattern2;

internal class TomatoesDecorator : SandwichDecorator
{

    public TomatoesDecorator(ISandwich sandwich) : base(sandwich) { }

    public override string Description() => base.Description() + ", tomatoe";

    public override decimal Price() => base.Price() + 0.3m;

}
