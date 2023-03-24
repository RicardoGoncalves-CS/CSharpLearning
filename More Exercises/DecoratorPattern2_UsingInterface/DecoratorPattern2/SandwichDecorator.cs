namespace DecoratorPattern2;

internal class SandwichDecorator : ISandwich
{

    private ISandwich _sandwich;

    public SandwichDecorator(ISandwich sandwich)
    {

        _sandwich = sandwich;

    }

    public virtual string Description()
    {

        return _sandwich.Description();

    }

    public virtual decimal Price()
    {

        return _sandwich.Price();

    }

}
