namespace JurassicPark.People.Employees;

internal class Scientist : Employee
{
    internal override string FirstName { get; set; }
    internal override string LastName { get; set; }
    internal override string Nationality { get; set; }
    internal override int Birthday { get; set; }
    internal override int BirthMonth { get; set; }
    internal override int BirthYear { get; set; }

    public override string GetFullName()
    {
        return $"{FirstName} {LastName}";
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