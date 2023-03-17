namespace JurassicPark.People.Visitors;

internal class Visitor : Person
{
    internal decimal Budget { get; set; }
    internal List<string> Interests { get; set; } = new List<string>();

    public void AddInterest(string interest)
    {
        Interests.Add(interest);
    }
}