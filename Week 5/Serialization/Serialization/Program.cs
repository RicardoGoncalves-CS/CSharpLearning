namespace Serialization;

internal class Program
{
    static void Main(string[] args)
    {
        Trainee trainee = new Trainee
        {
            FirstName = "Ricardo",
            LastName = "Goncalves",
            SpartaNo = 222
        };

        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        var serialiserXml = new SerialiserXml();

        string fullTraineePath = path + "\\Trainee.xml";

        serialiserXml.Serialise(trainee, fullTraineePath);


        Trainee deserialisedXml = serialiserXml.Deserialise<Trainee>(fullTraineePath);

        Console.WriteLine(deserialisedXml);
    }
}