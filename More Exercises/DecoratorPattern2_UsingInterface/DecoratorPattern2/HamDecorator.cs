namespace DecoratorPattern2;

internal class HamDecorator : SandwichDecorator
{

    public HamDecorator(ISandwich sandwich) : base(sandwich) { }

    public override string Description() => base.Description() + ", ham";

    public override decimal Price() => base.Price() + 0.3m;

}
