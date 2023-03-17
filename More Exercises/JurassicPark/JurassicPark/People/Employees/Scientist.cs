namespace JurassicPark.People.Employees;

internal class Scientist : Employee
{
    internal string FieldOfStudy { get; set; }
    internal string Role { get; set; }
    public Scientist(string fName, string lName)
    {
        id.FirstName = fName;
        id.LastName = lName;
    }

    public Scientist(string fName, string lName, string nationality)
    {
        id.FirstName = fName;
        id.LastName = lName;
        id.Nationality = nationality;
    }

    public Scientist(string fName, string lName, DateOnly dob)
    {
        id.FirstName = fName;
        id.LastName = lName;
        id.Birthday = dob.Day;
        id.BirthMonth = dob.Month;
        id.BirthYear = dob.Year;
    }

    public Scientist(string fName, string lName, string nationality, DateOnly dob)
    {
        id.FirstName = fName;
        id.LastName = lName;
        id.Nationality = nationality;
        id.Birthday = dob.Day;
        id.BirthMonth = dob.Month;
        id.BirthYear = dob.Year;
    }
}