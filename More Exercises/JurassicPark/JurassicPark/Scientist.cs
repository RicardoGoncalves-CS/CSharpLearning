namespace JurassicPark;

public class Scientist : Employee
{
    public string FieldOfStudy { get; set; }
    public override string Department { get; set; } = "Research";
    public virtual string Role { get; set; } = "Researcher";
    public virtual decimal Salary { get; set; } = 70000;
}