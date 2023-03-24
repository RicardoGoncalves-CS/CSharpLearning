using CSharpExploration.App.Beverages.BaseClasses;

namespace CSharpExploration.App.Beverages;

internal class Expresso : Coffee
{
    public Expresso() : base()
    {
        _description = "Expresso";
        _price = 1.50m;
        _caffeine = 50;
    }

    public override double GetCaffeine()
    {
        return _caffeine;
    }

    public override string GetDescription()
    {
        return _description;
    }

    public override decimal GetPrice()
    {
        return _price;
    }

    public override string GetUnitOfMeasurement()
    {
        return _caffeineUnit;
    }
}
