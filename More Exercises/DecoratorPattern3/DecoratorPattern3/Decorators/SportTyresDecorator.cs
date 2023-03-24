namespace DecoratorPattern3.Decorators;

internal class SportTyresDecorator : CarDecorator
{

    public SportTyresDecorator(Car car) : base(car) { }

    public override string Description() => _car.Description() + ", Sport tyres";

    public override int Speed() => _car.Speed() + 5;

    public override decimal Price() => _car.Price() + 1500;

}
