namespace JurassicPark.People;

internal abstract class Person
{
    internal Identity id { get; set; }

    internal string GetFullName()
    {
        return $"{id.FirstName} {id.LastName}";
    }

    internal string GetDateOfBirth()
    {
        if (id.Birthday != 0 && id.BirthMonth != 0 && id.BirthYear != 0) return $"{id.Birthday}/{id.BirthMonth}/{id.BirthYear}";
        else return "Information unavailable";
    }
    
    internal void SetDateOfBirth(DateOnly dob)
    {
        id.Birthday = dob.Day;
        id.BirthMonth = dob.Month;
        id.BirthYear = dob.Year;
    }
}
