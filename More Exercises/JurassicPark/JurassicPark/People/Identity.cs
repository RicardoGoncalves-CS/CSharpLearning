namespace JurassicPark.People;

// Identity is used to hold common identity related data used in different classes that derive from person to avoid bloating
internal class Identity
{
    internal string FirstName { get; set; }
    internal string LastName { get; set; }
    internal string Nationality { get; set; }
    internal int Birthday { get; set; }
    internal int BirthMonth { get; set; }
    internal int BirthYear { get; set; }
}
