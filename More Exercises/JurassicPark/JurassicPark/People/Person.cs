namespace JurassicPark.People;

// Abstract classe for all human objects
internal abstract class Person
{
    public Identity id = new Identity();

    public string GetFullName()
    {
        return $"{id.FirstName} {id.LastName}";
    }
    public string GetDateOfBirth()
    {
        if (id.Birthday != 0 && id.BirthMonth != 0 && id.BirthYear != 0) return $"{id.Birthday}/{id.BirthMonth}/{id.BirthYear}";
        else return "Information unavailable";
    }
    public void SetDateOfBirth(DateOnly dob)
    {
        id.Birthday = dob.Day;
        id.BirthMonth = dob.Month;
        id.BirthYear = dob.Year;
    }
}
