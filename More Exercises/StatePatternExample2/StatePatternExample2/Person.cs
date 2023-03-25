namespace StatePatternExample2;

internal class Person
{
    private IState _state;
    
    public Person()
    {
        _state = new NormalState();
    }

    public void Talk()
    {
        _state.Message();
    }

    public void DrinkCoffee()
    {
        _state = new CaffeinatedState();
    }

    public void DrinkWhiskey()
    {
        _state = new DrunkState();
    }

    public void SetState(IState state)
    {
        _state = state;
    }
}