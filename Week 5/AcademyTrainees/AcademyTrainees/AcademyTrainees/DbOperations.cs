using AcademyTrainees.Models;
using Microsoft.Data.SqlClient;

namespace AcademyTrainees;

public static class DbOperations
{
    public static void Add()
    {
        string name;
        string course;
        string location;

        using (var db = new AcademyContext())
        {
            Console.WriteLine("Create new trainee");

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Course: ");
            course = Console.ReadLine();

            Console.Write("Location: ");
            location = Console.ReadLine();

            var trainee = new Trainee
            {
                Name = name,
                Course = course,
                Location = location
            };

            db.Trainees.Add(trainee);
            db.SaveChanges();
        }
    }

    public static void Find()
    {
        int parsedId;
        CheckId("find", out parsedId);
        using (var db = new AcademyContext())
        {
            var trainee = db.Trainees.Find(parsedId);
            Console.WriteLine(trainee);
        }
    }

    public static void FindAll()
    {
        Console.WriteLine("All Trainees");
        using (var db = new AcademyContext())
        {
            foreach(var trainee in db.Trainees)
            {
                Console.WriteLine(trainee);
            }
        }
    }

    public static void Update()
    {
        int parsedId;
        CheckId("update", out parsedId);

        string name;
        string course;
        string location;


        using (var db = new AcademyContext())
        {
            var trainee = db.Trainees.Find(parsedId);

            Console.WriteLine("Update trainee (leave empty to keep current data in the field)");

            Console.Write("Name: ");
            name = Console.ReadLine();
            if (name != "") trainee.Name = name;

            Console.Write("Course: ");
            course = Console.ReadLine();
            if (course != "") trainee.Course = course;

            Console.Write("Location: ");
            location = Console.ReadLine();
            if (location != "") trainee.Location = location;

            db.SaveChanges();
            trainee = db.Trainees.Find(parsedId);

            Console.WriteLine($"Updated Trainee: {trainee}");
        }
    }

    public static void Delete()
    {
        int parsedId;
        CheckId("delete", out parsedId);
        
        using (var db = new AcademyContext())
        {
            var trainee = db.Trainees.Find(parsedId);

            db.Trainees.Remove(trainee);
            db.SaveChanges();
        }
    }

    private static bool CheckId( string change, out int parsedId)
    {
        Console.WriteLine($"Enter ID number to {change}");
        string id = Console.ReadLine();
        if(Int32.TryParse(id, out parsedId)) return true;

        Console.WriteLine("ID must be an integer");
        return CheckId(change, out parsedId);
    }
}
