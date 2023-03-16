namespace JurassicPark.People.Visitors;

internal class Visitor : Person
{
    internal override string FirstName { get; set; }
    internal override string LastName { get; set; }
    internal override string Nationality { get; set; } = "Information unavailable";
    internal override int Birthday { get; set; }
    internal override int BirthMonth { get; set; }
    internal override int BirthYear { get; set; }
    internal decimal Budget { get; set; }
    internal List<string> Interests { get; set; } = new List<string>();

    public Visitor(string fName, string lName)
    {
        FirstName = fName;
        LastName = lName;
    }

    public Visitor(string fName, string lName, string nationality)
    {
        FirstName = fName;
        LastName = lName;
        Nationality = nationality;
    }

    public Visitor(string fName, string lName, DateOnly dob)
    {
        FirstName = fName;
        LastName = lName;
        Birthday = dob.Day;
        BirthMonth = dob.Month;
        BirthYear = dob.Year;
    }

    public Visitor(string fName, string lName, string nationality, DateOnly dob)
    {
        FirstName = fName;
        LastName = lName;
        Nationality = nationality;
        Birthday = dob.Day;
        BirthMonth = dob.Month;
        BirthYear = dob.Year;
    }

    public override string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public void AddInterest(string interest)
    {
        Interests.Add(interest);
    }

    public override string GetDateOfBirth()
    {
        if (Birthday != 0 || BirthMonth != 0 || BirthYear != 0) return $"{Birthday}/{BirthMonth}/{BirthYear}";
        else return "Information unavailable";
    }

    public override void SetDateOfBirth(DateOnly dob)
    {
        Birthday = dob.Day;
        BirthMonth = dob.Month;
        BirthYear = dob.Year;
    }
}