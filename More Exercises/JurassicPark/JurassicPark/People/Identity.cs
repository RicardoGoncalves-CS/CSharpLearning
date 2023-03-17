namespace JurassicPark.People;

// Identity is used to hold common identity related data used in different classes that derive from person to avoid bloating
internal class Identity
{
    internal string FirstName { get; set; }
    internal string LastName { get; set; }
    internal string Nationality { get; set; } = "Information not available";
    internal int Birthday { get; set; }
    internal int BirthMonth { get; set; }
    internal int BirthYear { get; set; }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public string GetDateOfBirth()
    {
        if (Birthday != 0 || BirthMonth != 0 || BirthYear != 0) return $"{Birthday}/{BirthMonth}/{BirthYear}";
        else return "Information unavailable";
    }

    public void SetDateOfBirth(DateOnly dob)
    {
        Birthday = dob.Day;
        BirthMonth = dob.Month;
        BirthYear = dob.Year;
    }
}
