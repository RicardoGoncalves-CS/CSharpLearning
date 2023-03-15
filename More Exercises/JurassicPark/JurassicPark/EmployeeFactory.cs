namespace JurassicPark;

public static class EmployeeFactory
{
    public static Employee CreateEmployee(string employeeType)
    {
        switch (employeeType.ToLower())
        {
            case "scientist":
                return new Scientist();
            case "security":
                return new Security();
            default:
                throw new ArgumentException("Invalid employee type");
        }
    }
}