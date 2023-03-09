using SafariPark.App;

# region classes and structs
//Person cathy = new Person("Cathy", "French", 35);
//// Getter
//int age = cathy.Age;
//// Setter
//cathy.Age = 21;
//Console.WriteLine(cathy.FullName);

//// Overload
//var nish = new Person("Nish");
//Console.WriteLine(nish.FullName);

//// Using default values
//var peter = new Person("Peter", "Bellaby");

//var james = new Person("James", "Webb") { Age = 51 };

//var ruya = new Person
//{
//    FirstName = "Ruya",
//    LastName = "Kumru-Holroyd",
//    Age = 23
//};

//Point3D p = new Point3D(3, 6, 2);
//var p2 = new Point3D();
//Point3D p3;
//p3.x = 3;
//p3.y = 6;
//p3.z = 2;
//Point3D p4 = new Point3D(1, 7);

//Person john = new Person("John", "Jones") { Age = 20 };
//Point3D pt3D = new Point3D(5, 8, 2);
//DemoMethod(pt3D, john);
//{ }

//static void DemoMethod(Point3D pt, Person p)
//{
//    pt.y = 1000;
//    p.Age = 92;
//    p = null;
//}

//public struct Point3D
//{
//    public int x;
//    public int y, z;
//    public Point3D(int x, int y, int z = 5)
//    {
//        this.x = x;
//        this.y = y;
//        this.z = z;
//    }
//}
#endregion

Hunter hunter = new Hunter("Marion", "Jones", "Leica") { Age = 32 };

Console.WriteLine(hunter.Age);
Console.WriteLine(hunter.Shoot());

Hunter h2 = new Hunter();
Console.WriteLine(h2.Shoot());