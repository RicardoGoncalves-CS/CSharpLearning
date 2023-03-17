namespace JurassicPark.People.Visitors;

internal class Visitor : Person
{
    internal decimal Budget { get; set; }
    internal List<string> Interests { get; set; } = new List<string>();

    public Visitor(string fName, string lName)
    {
        id.FirstName = fName;
        id.LastName = lName;
    }

    public Visitor(string fName, string lName, string nationality)
    {
        id.FirstName = fName;
        id.LastName = lName;
        id.Nationality = nationality;
    }

    public Visitor(string fName, string lName, DateOnly dob)
    {
        id.FirstName = fName;
        id.LastName = lName;
        id.Birthday = dob.Day;
        id.BirthMonth = dob.Month;
        id.BirthYear = dob.Year;
    }

    public Visitor(string fName, string lName, string nationality, DateOnly dob)
    {
        id.FirstName = fName;
        id.LastName = lName;
        id.Nationality = nationality;
        id.Birthday = dob.Day;
        id.BirthMonth = dob.Month;
        id.BirthYear = dob.Year;
    }

    public void AddInterest(string interest)
    {
        Interests.Add(interest);
    }
}