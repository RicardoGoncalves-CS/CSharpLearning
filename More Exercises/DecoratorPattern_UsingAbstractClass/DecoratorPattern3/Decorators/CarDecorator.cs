namespace DecoratorPattern3.Decorators;

internal class CarDecorator : Car
{

    protected Car _car;

    public CarDecorator(Car car) 
    {
        _car = car;
    }

    public override string Description() => _car.Description();

    public override decimal Price() => _car.Price();

    public override int Speed() => _car.Speed();

}
