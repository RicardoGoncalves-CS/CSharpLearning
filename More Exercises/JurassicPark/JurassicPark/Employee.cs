namespace JurassicPark;

public abstract class Employee : Person
{
    public virtual string Department { get; set; }
    public virtual string Role { get; set; }
    public virtual decimal Salary { get; set; }
}