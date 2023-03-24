namespace DecoratorPattern2;

internal class LettuceDecorator : SandwichDecorator
{

    public LettuceDecorator(ISandwich sandwich) : base(sandwich) { }

    public override string Description() => base.Description() + ", lettuce";

    public override decimal Price() => base.Price() + 0.2m;

}
