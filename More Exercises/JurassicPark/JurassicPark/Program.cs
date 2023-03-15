namespace JurassicPark;

internal class Program
{
    static void Main()
    {
        Employee emp1 = EmployeeFactory.CreateEmployee("Scientist");
        emp1.Name = "Benedict";
        emp1.Department = "Research";
        emp1.Role = "Senior Researcher";
        emp1.Salary = 100000;

        Scientist emp2 = (Scientist)EmployeeFactory.CreateEmployee("Scientist");
        emp2.Name = "Charles";
        emp2.Department = "Research";
        emp2.Role = "Head of Research";
        emp2.Salary = 150000;
        emp2.FieldOfStudy = "Genetics";

        Employee emp3 = EmployeeFactory.CreateEmployee("scientist");
        Scientist newScientist = (Scientist)emp3;
        newScientist.Name = "John";
        newScientist.Role = "Biologist";
        newScientist.FieldOfStudy = "Biology";

        Employee emp4 = EmployeeFactory.CreateEmployee("security");
        Security newSecurity = (Security)emp4;
        newSecurity.Name = "Joseph";

        Console.WriteLine($"{emp1.Name} works as {emp1.Role.ToLower()} at the {emp1.Department.ToLower()} department. His annual salary is {emp1.Salary.ToString("C")}");
        Console.WriteLine($"{emp2.Name} works as {emp2.Role.ToLower()} at the {emp2.Department.ToLower()} department. His field of study is {emp2.FieldOfStudy.ToLower()} and has an annual salary of {emp2.Salary.ToString("C")}");
        Console.WriteLine($"{newScientist.Name} works as {newScientist.Role.ToLower()} at the {newScientist.Department.ToLower()} department. His field of study is {newScientist.FieldOfStudy.ToLower()} and has an annual salary of {newScientist.Salary.ToString("C")}");
        Console.WriteLine($"{newSecurity.Name} works as {newSecurity.Role.ToLower()} at the {newSecurity.Department.ToLower()} department. His annual salary of {newSecurity.Salary.ToString("C")}");
    }
}