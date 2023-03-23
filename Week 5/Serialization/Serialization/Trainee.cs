namespace Serialization;

public class Trainee
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public int? SpartaNo { get; init; }
    public string FullName => $"{FirstName} {LastName}"; // This notation is called expression body
    public override string ToString()
    {
        return $"{SpartaNo} - {FullName}";
    }
}
