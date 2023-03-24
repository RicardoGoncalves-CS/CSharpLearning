namespace DecoratorPattern3.Decorators;

internal class SportEngineDecorator : CarDecorator
{

    public SportEngineDecorator(Car car) : base(car) { }

    public override string Description() => _car.Description() + ", Sport Engine";

    public override int Speed() => _car.Speed() + 60;

    public override decimal Price() => _car.Price() + 6000;

}
