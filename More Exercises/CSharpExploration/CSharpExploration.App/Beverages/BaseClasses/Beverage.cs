namespace CSharpExploration.App.Beverages.BaseClasses;

internal abstract class Beverage
{
    protected string _description = "No bevarage";
    protected decimal _price;

    public abstract string GetDescription();

    public abstract decimal GetPrice();

    public abstract string GetUnitOfMeasurement();
}