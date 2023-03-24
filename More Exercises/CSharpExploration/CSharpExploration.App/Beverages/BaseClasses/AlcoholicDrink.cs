namespace CSharpExploration.App.Beverages.BaseClasses;

internal abstract class AlcoholicDrink : Beverage
{
    protected double _alcohol;
    protected string _alcoholUnit = "% ABV";

    public abstract double GetAlcohol();
}