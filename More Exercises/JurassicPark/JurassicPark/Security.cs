namespace JurassicPark;

internal class Security : Employee
{
    public override string Department { get; set; } = "Security";
    public virtual string Role { get; set; } = "Security guard";
    public virtual decimal Salary { get; set; } = 50000;
}