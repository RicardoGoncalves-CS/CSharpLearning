namespace DecoratorPattern3.Decorators;

internal class PremiumInteriorDecorator : CarDecorator
{

    public PremiumInteriorDecorator(Car car) : base(car) { }

    public override string Description() => _car.Description() + ", Luxury interior";

    public override decimal Price() => _car.Price() + 5000;

}
