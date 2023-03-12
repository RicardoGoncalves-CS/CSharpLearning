using SafariPark.App;
using System.Runtime.CompilerServices;

#region classes and structs
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

#region inheritance
//Hunter hunter = new Hunter("Marion", "Jones", "Leica") { Age = 32 };

//Console.WriteLine(hunter.Age);
//Console.WriteLine(hunter.Shoot());

//Hunter h2 = new Hunter();
//Console.WriteLine(h2.Shoot());

//Console.WriteLine($"{hunter}");

//Console.WriteLine();

//Rectangle rect = new Rectangle(2, 3);
//Console.WriteLine(rect);

//Console.WriteLine();

//Airplane airplane = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150}; 
//airplane.Ascend(500); 
//Console.WriteLine(airplane.Move(3)); 
//Console.WriteLine(airplane); 
//airplane.Descend(200); 
//Console.WriteLine(airplane.Move()); 
//airplane.Move(); 
//Console.WriteLine(airplane);
#endregion

#region polymorphism

//List<IMovable> gameObjects = new List<IMovable>()
//{
//    new Person("Cathy", "French"),
//    new Airplane(400, 200, "Boeing") { NumPassengers = 55 },
//    new Vehicle(12, 20){NumPassengers = 6 },
//    new Hunter("Henry", "Hodgkins", "Pentax")
//};

//foreach (var movable in gameObjects)
//{
//    Console.WriteLine($"{movable.GetType()} is {movable.Move()} for a distance of {movable.Distance}");
//}

//Console.WriteLine();

////foreach (var gameObj in gameObjects)
////{
////    Console.WriteLine(gameObj);
////}

//Console.WriteLine();

//Person yolanda = new Person("Yolanda", "Young");
//SpartaWrite(yolanda); 

//void SpartaWrite(object obj)
//{
//    //var hunterObj = (Hunter)obj;
//    //Console.WriteLine(hunterObj.Shoot());
//    Console.WriteLine(obj.ToString());
//}

#endregion

#region Polymorphic shootout

//List<IShootable> myWeapons = new List<IShootable>()
//{
//    new LaserGun("MegaRaySupreme"),
//    new WaterPistol("SuperWaterPistols"),
//    new Hunter("Sylvester", "Stallone", new Camera("Leica")),
//    new LaserGun("TinyBlaster"),
//    new WaterPistol("WetMaker"),
//    new Camera("Canon"),
//    new Hunter("Arnold", "Schwarzenegger", new WaterPistol("HeavyDamage")),
//    new Hunter("James", "Bond", new LaserGun("SolarFlare"))
//};

//foreach(IShootable item in myWeapons)
//{
//    Console.WriteLine(item.Shoot());
//}

#endregion

#region Object comparison

//var bobOne = new Person("Bob", "Builder") { Age = 25 };
//var bobTwo = bobOne;
//var areSame = bobOne.Equals(bobTwo);  // Both hold the same reference in the stack to the address location in the heap

//var bobThree = new Person("Bob", "builder") { Age = 25 };
//var areSameOneThree = bobOne.Equals(bobThree);  // Although they hold the same values they are different objects as they hold difference references in the stack

//var operatorEquals = bobOne == bobThree;
//var operatorNotEquals = bobOne != bobThree;

//var bobFour = new Person("Bob", "Builder") { Age = 23 }; 

//List<Person> personList = new List<Person> { bobOne, bobTwo, bobThree, bobFour };

//personList.Sort();

//Console.WriteLine();

#endregion

#region Collections

var helen = new Person
{
    FirstName = "Helen",
    LastName = "Troy",
    Age = 22
}; 

var will = new Hunter
{
    FirstName = "William",
    LastName = "Shakespeare",
    Age = 457
}; 

Console.WriteLine("List of people");

List<Person> thePeople = new List<Person> { helen, will }; 

foreach (var person in thePeople)
{
    Console.WriteLine(person);
}

Console.WriteLine();

List<int> theNumbers = new List<int> { 5, 4, 3, 9, 0 };

theNumbers.Add(8);
theNumbers.Sort();
theNumbers.RemoveRange(1, 2);
theNumbers.Insert(2, 1);
theNumbers.Reverse();
theNumbers.Remove(9);

foreach(int num in theNumbers)
{
    Console.Write($"{num}");
}

// LINKED LIST

Console.WriteLine("LinkedList of people");

LinkedList<Person> thePeopleLinked = new LinkedList<Person>(); 

thePeopleLinked.AddFirst(helen);
thePeopleLinked.AddLast(will); 

LinkedListNode<Person> insertNode = thePeopleLinked.Find(will)!;

thePeopleLinked.AddBefore(insertNode, new Person { FirstName = "Linda", LastName = "Smith", Age = 45 });

// QUEUE - First In First Out

Console.WriteLine("Queue of people"); 

var myQueue = new Queue<Person>();

myQueue.Enqueue(helen);
myQueue.Enqueue(will);

myQueue.Enqueue(new Person("Cathy")); 

foreach (var q in myQueue)
{
    Console.WriteLine(q);
}

var first = myQueue.Peek();
var serve = myQueue.Dequeue(); 

Console.WriteLine();

// STACK - First In Last Out

Console.WriteLine("Stack of numbers");

int[] original = new int[] { 1, 2, 3, 4, 5 };
int[] reversed = new int[original.Length]; 

var stack = new Stack<int>();

// Populate the stack
foreach (var n in original)
{
    stack.Push(n);
}

// Write out the stack
foreach (var s in stack)
{
    Console.WriteLine(s);
}

// Populate reversed from the stack
for (int i = 0; i < original.Length; i++)
{
    reversed[i] = stack.Pop();
}

Console.WriteLine();

// HASHSET

Console.WriteLine("HashSet of people");

var peopleSet = new HashSet<Person> { helen, new Person("Jasmine", "Carter"), new Person("Andrei", "Masters") };

///////////

var successMartin = peopleSet.Add(        // <--
    new Person                            // <--
    {                                     // <--
        FirstName = "Martin",             // <--
        LastName = "Beard"                // <--
    });                                   // <--

var successHelen = peopleSet.Add(         // <--
    new Person                            // <--
    {                                     // <--
        FirstName = "Helen",              // <--
        LastName = "Troy",                // <--
        Age = 22                          // <--
    });                                   // <--


var morePeople = new HashSet<Person>{ new Person("Cathy", "French"), new Person("Jasmine", "Carter") };

peopleSet.IntersectWith(morePeople);

var vehicleSet = new HashSet<Vehicle>()

{
 new Vehicle{ NumPassengers = 3, Speed = 2},
 new Vehicle{ Speed = 100 }
};

var success = vehicleSet.Add(new Vehicle { Speed = 100 });

foreach (var entry in peopleSet)
{
    Console.WriteLine(entry);
}

Console.WriteLine();

// DICTIONARY

Console.WriteLine("Dictionary of people");

var personDict = new Dictionary<string, Person>
{ 
    {"helen", helen }, 
    {"sherlock", new Person("Sherlock", "Holmes") {Age = 40 } } 
}; 

var p = personDict["sherlock"];

personDict.Add("will", will); Console.WriteLine();

/////

Console.WriteLine("Dictionary problem");

string input = "The cat in the hat comes back";
input = input.Trim().ToLower(); 

var countDict = new Dictionary<char, int>(); 

foreach (var c in input)
{
    if (countDict.ContainsKey(c))
    {
        countDict[c]++;
    }
    else
    {
        countDict.Add(c, 1);
    }
}

foreach (var entry in countDict)
{
    Console.WriteLine(entry);
}

Console.WriteLine();

Console.WriteLine("Keys");

foreach (var key in countDict.Keys)
{
    Console.Write(key + " ");
}

Console.WriteLine("\nValues");

foreach (var value in countDict.Values)
{
    Console.Write(value + " ");
}

#endregion