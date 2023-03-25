namespace StatePatternExample2;

internal class NormalState : IState
{
    public void Message()
    {
        Console.WriteLine("Hi there! I'm feeling a little tired today");
    }
}