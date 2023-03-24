namespace CSharpExploration.App.Beverages.BaseClasses;

internal abstract class Coffee : Beverage
{
    protected double _caffeine;
    protected string _caffeineUnit = "milligrams";

    public abstract double GetCaffeine();

}
