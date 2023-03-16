namespace JurassicPark.People.Employees;

internal class Employee : Person
{
    internal override string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    internal override string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    internal override string Nationality { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    internal override int Birthday { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    internal override int BirthMonth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    internal override int BirthYear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override string GetDateOfBirth()
    {
        throw new NotImplementedException();
    }

    public override string GetFullName()
    {
        throw new NotImplementedException();
    }

    public override void SetDateOfBirth(DateOnly dob)
    {
        throw new NotImplementedException();
    }
}