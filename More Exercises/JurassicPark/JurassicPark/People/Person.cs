namespace JurassicPark.People;

internal abstract class Person
{
    internal abstract string FirstName { get; set; }
    internal abstract string LastName { get; set; }
    internal abstract string Nationality { get; set; }
    internal abstract int Birthday { get; set; }
    internal abstract int BirthMonth { get; set; }
    internal abstract int BirthYear { get; set; }

    public abstract string GetFullName();
    public abstract string GetDateOfBirth();
    public abstract void SetDateOfBirth(DateOnly dob);
}
