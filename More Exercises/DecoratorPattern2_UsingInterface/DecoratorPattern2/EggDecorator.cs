namespace DecoratorPattern2;

internal class EggDecorator : SandwichDecorator
{

    public EggDecorator(ISandwich sandwich) : base(sandwich) { }

    public override string Description() => base.Description() + ", egg";

    public override decimal Price() => base.Price() + 0.3m;

}