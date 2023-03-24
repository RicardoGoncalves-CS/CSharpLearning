using CSharpExploration.App.Beverages.BaseClasses;


namespace CSharpExploration.App.Beverages;

internal class Beer : AlcoholicDrink
{
    public Beer() : base()
    {

        _description = "Beer";
        _price = 2.9m;
        _alcohol = 17.7;
    }

    public override double GetAlcohol()
    {
        return _alcohol;
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
        return _alcoholUnit;
    }
}