namespace DecoratorPattern2;

internal class Sandwich : ISandwich
{

    private string _description = "Sourdough bread";

    private decimal _price = 0.5m;

    public string Description()
    {

        return _description;

    }

    public decimal Price()
    {

        return _price;

    }

}
