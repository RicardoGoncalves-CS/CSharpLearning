using CSharpExploration.App.Beverages.BaseClasses;

namespace CSharpExploration.App.Beverages.BeverageDecorators;

internal abstract class CoffeeDecorator : Coffee
{
    protected Coffee _coffee;

    public CoffeeDecorator(Coffee coffee)
    {
        _coffee = coffee;
    }

    public override string GetDescription() => _coffee.GetDescription();

    public override decimal GetPrice() => _coffee.GetPrice();
}
