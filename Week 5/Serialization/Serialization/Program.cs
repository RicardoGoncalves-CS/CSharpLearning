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

        Course tech205 = new Course
        {
            Title = "Tech 205",
            Subject = "C# Development"
        };
        tech205.AddTrainee(trainee);
        tech205.AddTrainee(
             new Trainee
             {
                 FirstName = "Laura",
                 LastName = "Tozer",
                 SpartaNo = 1
             });


        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        var serialiserXml = new SerialiserXml();
        var serialiserJson = new SerialiserJson();

        string fullTraineePath = path + "\\Trainee.xml";
        Serialise(trainee, fullTraineePath, serialiserXml);
        Trainee traineeDeserialisedXml = Deserialise<Trainee>(fullTraineePath, serialiserXml);

        string fullCoursePath = path + "\\Course.xml";
        Serialise(tech205, fullCoursePath, serialiserXml);
        Course courseDeserialisedXml = Deserialise<Course>(fullCoursePath, serialiserXml);

        string fullTraineePathJson = path + "\\Trainee.json";
        Serialise(trainee, fullTraineePathJson, serialiserJson);
        Trainee traineeDeserialisedJson = Deserialise<Trainee>(fullTraineePathJson, serialiserJson);

        string fullCoursePathJson = path + "\\Course.json";
        Serialise(tech205, fullCoursePathJson, serialiserJson);
        Course courseDeserialisedJson = Deserialise<Course>(fullCoursePathJson, serialiserJson);

        Console.WriteLine(traineeDeserialisedXml);
        Console.WriteLine(courseDeserialisedXml);
        Console.WriteLine(traineeDeserialisedJson);
        Console.WriteLine(courseDeserialisedJson);


        static void Serialise<T>(T objToSerialise, string toPath, ISerialiser serialiser)
        {
            serialiser.Serialise(objToSerialise, toPath);
        }


        static T Deserialise<T>(string fromPath, ISerialiser serialiser)
        {
            return serialiser.Deserialise<T>(fromPath);
        }
    }
}