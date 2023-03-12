[Go to the root folder](https://github.com/RicardoGoncalves-CS/Sparta)

# Week 3 Notes

1. [Advanced NUnit](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#advanced-nunit)
2. [Test Driven Development](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#test-driven-development)
3. [Object-Oriented Programming](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#object-oriented-programming)
4. [Abstraction](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#abstraction)
5. [Encapsulation](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#encapsulation)
6. [Inheritance](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#inheritance)
7. [Polymorphism](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#polymorphism)
8. [SOLID Principles](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#solid-principles)
9. [Objects Comparison](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#objects-comparison)
10. [Collections](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#collections)

### Advanced NUnit

As explained in [Week 2 Unit Testing notes](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%202#2-unit-testing) in our Sparta training we use NUnit as the testing framework for our C# applications.

For a comprehensive list of features and attributes please refer to [NUnit official documentation](https://docs.nunit.org/).

The [Test] and [TestCase] attributes have been already covered during Week 2, which are used to mark methods that represent a test.

During this lesson we covered some more advanced features including:
-	**[SetUp]**: Marks a method that should run before each test method.
-	**[OneTimeSetUp]**: Marks a method that should run once before all the test methods.
-	**[TearDown]**: Mark a method that should run after each test method is executed.
-	**[OneTimeTearDown]**: Marks a method that should run once after all the test methods.
-	**[Ignore]**: Marks a method that should not be executed.
-	**[Region]**: This is not an NUnit attribute, but a C# language construct used to define sections of code. It can be useful to organise code by function or feature.
-	**Helper Methods**: These are custom methods that help with common tasks or operations within the test methods. They can be used to reduce code duplication and make tests more maintainable. We can define helper methods within the test fixture or in separate classes.

Below is a simple example of the use of some of the NUnit attributes mentioned above.

In the example we use a **‘Calculator’** class that has an **‘Add’** method to add 2 integers and return the result. We want to test if the **‘Add’** method works correctly.

In the **[SetUp]** we create a new instance of the **’Calculator’** class before each test.

The **[TearDown]** method cleans up the resources used by the class after each test.

The **[Test]** method will test the **’Add’** method from the **’Calculator’** class.

```C#
// Example of the usage of some NUnit attributes
using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        // Create a new instance of the Calculator class before each test
        calculator = new Calculator();
    }

    [Test]
    public void Add_TwoNumbers_ReturnsCorrectResult()
    {
        // Arrange
        int num1 = 2;
        int num2 = 6;

        // Act
        int result = calculator.Add(num1, num2);

        // Assert
        Assert.AreEqual(8, result);
    }

    [TearDown]
    public void Teardown()
    {
        // Clean up any resources used by the Calculator class after each test
        calculator = null;
    }
}
```

### Test Driven Development

Test-driven development (TDD) is a software development methodology that emphasizes writing tests before writing code. The process involves creating automated tests that define the expected behavior of a piece of code, and then writing the code to pass those tests.

The TDD process typically involves three main steps:

1. **Write a failing test**: The first step is to write a test that defines the desired behavior of a piece of code, but which currently fails because the code has not yet been written. This test is typically written using a testing framework, such as JUnit or NUnit, and should be as specific as possible, in order to minimize the risk of false positives or false negatives.

2. **Write the minimum code required to pass the test**: Once the failing test has been written, the next step is to write the minimum amount of code required to pass the test. This code should be simple, focused, and easy to read and understand, and should be designed to pass the test as quickly and efficiently as possible.

3. **Refactor the code**: Once the test has been passed, the code can be refactored, or optimized, to improve its performance, readability, and maintainability. This step involves identifying and removing any unnecessary or redundant code, and making sure that the code adheres to best practices and coding standards.

By following this process, TDD helps to ensure that code is tested thoroughly and consistently, that bugs are caught early and fixed quickly, and that the code is designed to be modular, maintainable, and scalable. It also promotes collaboration and communication between developers, and helps to reduce the risk of errors and regressions, which can be costly and time-consuming to fix.

In summary, test-driven development is a software development methodology that emphasizes writing tests before writing code. By following a rigorous and disciplined process of writing tests, writing code, and refactoring, TDD helps to ensure that code is tested thoroughly and consistently, that bugs are caught early and fixed quickly, and that the code is designed to be modular, maintainable, and scalable.

### Object-Oriented Programming

**Object-oriented programming** (OOP) is a programming paradigm that focuses on creating **objects** that encapsulate data and behaviour. These objects are instances of **classes**, which serve as templates for creating objects with similar attributes and methods.

One of the key features of OOP is **encapsulation**, which refers to the bundling of data and methods within a class, so that they can be accessed and modified only through the class's methods. This provides a level of abstraction that makes it easier to manage the complexity of larger programs and to avoid conflicts between different parts of the code.

**Abstraction** is also a fundamental concept in object-oriented programming that involves focusing on the essential features of an object or system, while ignoring the details that are not relevant to its behavior. It allows developers to reduce complexity, improve modularity, and promote code reuse by defining interfaces or abstract classes that specify the methods that an implementing class must provide, without specifying how those methods should be implemented.

Another important aspect of OOP is **inheritance**, which allows classes to inherit attributes and methods from a parent class, reducing the need for repetitive code and promoting code reuse. Inheritance can also be used to create more specific classes from a general one, through a process called subclassing.

**Polymorphism** is another feature of OOP that allows objects to take on multiple forms, depending on the context in which they are used. This can be achieved through method overriding, which allows a subclass to provide a different implementation of a method inherited from a parent class, or through method overloading, which allows multiple methods with the same name but different parameters to coexist within a class.

OOP has become a widely used programming paradigm due to its flexibility, scalability, and reusability. It has been applied in a variety of domains, ranging from desktop applications and video games to web development and machine learning. However, like any programming paradigm, it has its strengths and weaknesses, and its suitability depends on the specific requirements of the project at hand.

### Abstraction

Abstraction is a fundamental concept in computer science and software engineering that involves reducing complex systems or concepts to simpler, more manageable models. In software development, abstraction is a technique that helps to manage complexity and promote reusability by hiding unnecessary details and focusing on the essential features of a system.

The process of abstraction involves identifying and defining the core features and behaviors of a system or object, while ignoring the details that are not relevant to its function. This is typically achieved by creating abstract classes or interfaces that define the properties and methods that an object must have, without specifying how those properties and methods are implemented.

One of the key benefits of abstraction is that it allows developers to work at a higher level of abstraction, which can make it easier to understand and reason about complex systems. By abstracting away the details that are not relevant to the problem at hand, developers can focus on the essential features of the system, and design more effective solutions.

Abstraction also promotes reusability by allowing developers to create generic, abstract classes or interfaces that can be used to define the behavior of multiple objects. This makes it easier to write code that is modular and scalable, and can be easily extended or modified as the system evolves.

```C#
// Example of Abstraction

public abstract class Animal
{
    public abstract string GetName();
    public abstract void MakeSound();
}

public class Dog : Animal
{
    public override string GetName()
    {
        return "Dog";
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal
{
    public override string GetName()
    {
        return "Cat";
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

public class AbstractionExample
{
    public static void Main()
    {
        Animal dog = new Dog();
        Console.WriteLine($"{dog.GetName()} says:");
        dog.MakeSound();

        Animal cat = new Cat();
        Console.WriteLine($"{cat.GetName()} says:");
        cat.MakeSound();
    }
}

```

In this code example, we define an abstract class **Animal** with abstract methods **GetName()** and **MakeSound()**. 

We then create two concrete classes, **Dog** and **Cat**, which inherit from **Animal** and implement the **GetName()** and **MakeSound()** methods.

By using an abstract class and methods, we are able to define a common interface for different animals, while allowing each animal to implement its own unique behavior. 

We can then create instances of the **Dog** and **Cat** classes, and call their **GetName()** and **MakeSound()** methods to display their respective names and sounds.

In summary, abstraction is a fundamental concept in software engineering that helps to manage complexity and promote reusability by reducing complex systems to simpler, more manageable models. By focusing on the essential features of a system or object, and abstracting away unnecessary details, developers can design more effective, modular, and scalable solutions that are easier to understand and maintain.

### Encapsulation

Encapsulation refers to the practice of hiding the internal details of an object and providing a clear interface for accessing and modifying its state. Encapsulation helps to protect an object's internal state from unauthorized modification, which can help to ensure the correctness and reliability of your code.

In C#, encapsulation is achieved by using access modifiers like public, protected, and internal to control access to an object's properties, fields, and methods. By making certain properties or methods private, for example, you can ensure that they can only be accessed or modified from within the object itself, which helps to prevent unintended side effects and makes your code more robust and maintainable.

**Description of access modifiers in C#**:

- **public**: The code is accessible for all classes
- **private**: The code is only accessible within the same class
- **protected**: The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
- **internal**: The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter

In addition to access modifiers, encapsulation can also be achieved through the use of properties, attributes, and other language features that help to control the way that an object's state is accessed and modified. By providing a clear interface for accessing an object's properties and methods, you can make your code more readable, understandable, and reusable.

```C#
// Example of encapsulation

public abstract class Animal
{
    private int _age;

    public string Name { get; set; } = "";
    public string Sound { get; protected set; } = "";

    public int Age
    {
        get
        {
            return _age;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }
            _age = value;
        }
    }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string GetName()
    {
        return Name;
    }

    public void Rename(string name)
    {
        Name = name;
    }

    public abstract void MakeSound();

    public void NewSound(string newSound)
    {
        Sound = newSound;
    }

    public void Birthday()
    {
        Age++;
    }
}
```

In the example above an abstract class **Animal** was created to demonstrate principles of encapsulation.

The class has three private fields: **_age**, **_name**, and **_sound**. 

The **_age** field is accessed through a public property named Age, which has a private setter and ensures that the age is not negative. 

The **_name** and **_sound** fields are accessed through public properties **Name** and **Sound**, respectively. 

**Name** has both a getter and setter, while **Sound** has a getter and a protected setter.

The class also has several public methods for interacting with an instance of the Animal class. 

- **GetName()**: returns the name of the animal.
- **Rename(string name)**: sets a new name for the animal.
- **NewSound(string newSound)**: sets a new sound for the animal.
- **Birthday()**: increments the age of the animal by one.

It also has an abstract method **MakeSound()**, which means any class that inherits from Animal must provide an implementation for this method.

Overall, encapsulation is an essential concept in object-oriented programming, and it plays a critical role in ensuring the correctness and reliability of your code. By using encapsulation to protect an object's internal state and provide a clear interface for accessing and modifying it, you can make your code more secure, maintainable, and effective.

### Inheritance

Inheritance enables a new class to be based on an existing class. The existing class is known as the parent or base class, and the new class is called the child or derived class. Inheritance allows the child class to inherit the properties and behaviors of the parent class, allowing for code reuse and reducing the amount of code needed to create new classes.

Inheritance is represented in code by using the colon (:) symbol followed by the name of the parent class in the declaration of the child class. The child class can then access the public and protected members of the parent class, including fields, methods, and properties.

Child classes can also add new members, including additional fields, methods, and properties. This ability to extend and modify the functionality of the parent class is known as inheritance's polymorphism aspect, which allows a child class to be treated as if it were an instance of the parent class.

```C#
// Example of inheritance

public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
        Sound = "Woof Woof!";
    }

    public override void MakeSound()
    {
        Console.WriteLine(Sound);
    }
}
```

In this example, **Dog** is a subclass of **Animal**. The constructor for **Dog** accepts a **name** and **age**, which are passed to the constructor of **Animal** using the **base keyword**. 

We also set the Sound property of the Dog instance to "Woof Woof!".

The **MakeSound** method is marked with the **override keyword**, which means that it overrides the **MakeSound** method declared in the **Animal** class.

Inheritance is a powerful tool that can greatly simplify the development of large-scale applications by reducing the amount of code needed to create new classes and promoting code reuse. However, it is important to use inheritance carefully to avoid creating complex and difficult-to-maintain code.

### Polymorphism

Polymorphism allows objects of different classes to be treated as if they are of the same type. Polymorphism allows developers to write code that can work with objects of different classes in a unified manner, without having to know the specific details of each object. This can greatly simplify code and make it more flexible and reusable.

There are two main types of polymorphism: 

- **Overloading (compile-time polymorphism)**: method overloading allows a class to have multiple methods with the same name but different parameters.
- **Overriding (runtime polymorphism)**: method overriding allows a subclass to provide its own implementation of a method that is already defined in its parent class.

Polymorphism is often achieved through the use of interfaces or abstract classes, which define a common set of methods and properties that can be implemented in different ways by different classes. This allows objects of different classes to be treated as if they are of the same type, as long as they implement the required methods and properties.

```C#
// Example of polymorphism

Dog bigDog = new Dog("Scruffy", 2);
Cat smallCat = new Cat("Paws", 4);

dog.MakeSound();    // output "Woof Woof!"
cat.MakeSound();    // output "Meow!"
```

The example above demonstrates runtime polymorphism by using overriding on the **MakeSound()** method.

Both **Dog** and **Cat** classes have a **MakeSound()** method with different implementations.

The code creates objects of both **Dog** and **Cat** classes, and calls the **MakeSound()** method on each object, which produces different outputs based on the implementation of the **MakeSound()** method in each class.

Overall, polymorphism is a powerful concept that enables developers to write more flexible, modular, and reusable code, and is a key aspect of object-oriented programming.

### SOLID Principles

SOLID principles are a set of guidelines for object-oriented programming that help to ensure code is maintainable, reusable, and easy to understand. 

The principles are:

- Single Responsibility Principle (SRP): A class should have only one reason to change, meaning it should have only one responsibility. This ensures that changes to one part of the codebase won't affect other parts unnecessarily.
- Open/Closed Principle (OCP): A class should be open for extension but closed for modification. This means that new functionality should be added through inheritance or composition rather than by modifying existing code.
- Liskov Substitution Principle (LSP): Subtypes should be substitutable for their base types. This means that any instance of a base class should be able to be replaced by an instance of a derived class without changing the correctness of the program.
- Interface Segregation Principle (ISP): Clients should not be forced to depend on methods they do not use. This means that interfaces should be segregated into smaller, more specific interfaces that clients can implement only the methods they need.
- Dependency Inversion Principle (DIP): High-level modules should not depend on low-level modules; both should depend on abstractions. Abstractions should not depend on details; details should depend on abstractions. This means that code should depend on abstractions rather than concrete implementations, allowing for easier changes and updates.

Following these principles can lead to code that is easier to maintain, test, and extend over time.

### Objects Comparison

In C#, object comparison is the process of determining whether two objects are equal or not. There are different types of object comparison in C# depending on the context and the needs of the program.

The most common way to compare objects in C# is to use the **Equals** method.

The **Equals** method is inherited from the System.Object class and can be overridden in derived classes to provide custom equality comparison logic. By default, the Equals method checks if the two objects being compared refer to the same memory location, i.e., if they are the same instance of an object.

```C#
// Example of the use of Equals()

new Dog("Buddy", 2);
Dog dog2 = new Dog("Buddy", 2);
Dog dog3 = dog1;
int num1 = 10;
int num2 = 10;

// Equals
Console.WriteLine(dog1.Equals(dog2));   // output false: compares variable references
Console.WriteLine(dog1.Equals(dog3));   // output true: compares variable references
Console.WriteLine(num1.Equals(num2));   // output true: compares variable values
```

In addition to the Equals method, C# provides other ways to compare objects, including:

The **ReferenceEquals** method compares two objects for reference equality, i.e., it returns true if the two objects are the same instance of an object.

```C#
// Example of the use of ReferenceEquals()

Dog dog1 = new Dog("Buddy", 2);
Dog dog2 = new Dog("Buddy", 2);
Dog dog3 = dog1;

// ReferenceEquals
Console.WriteLine(ReferenceEquals(dog1, dog2));     // output false: compares variable references
Console.WriteLine(ReferenceEquals(dog1, dog3));     // output true: compares variable references
```

The **==** and **!=** operators can be used to compare objects for equality or inequality. By default, they check if the two objects are the same instance of an object, but they can be overloaded to provide custom equality comparison logic.

```C#
// Example of the use of == & !=

Dog dog1 = new Dog("Buddy", 2);
Dog dog2 = new Dog("Buddy", 2);
Dog dog3 = dog1;
int num1 = 10;
int num2 = 10;

Console.WriteLine(dog1 == dog2);    // output false
Console.WriteLine(dog1 == dog3);    // output true
Console.WriteLine(num1 == num2);    // output true
Console.WriteLine(num1 != num2);    // output false
```

The **IComparable** interface defines a method CompareTo that can be used to compare two objects of the same type. The CompareTo method returns a value indicating whether the first object is less than, equal to, or greater than the second object.

```C#
// Example of the use of IComparable

public class Dog : IComparable<Dog>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int CompareTo(Dog other)
    {
        if (other == null) return 1;

        // First, compare by name
        int nameCompare = Name.CompareTo(other.Name);
        if (nameCompare != 0) return nameCompare;

        // If the names are the same, compare by age
        return Age.CompareTo(other.Age);
    }
}
```

In this example above **Dog** implements the **IComparable** interface by providing a **CompareTo** method that takes another **Dog** object as a parameter and returns an integer indicating the relationship between the two objects.

The **CompareTo** method first compares the **Name** properties of the two dogs. If they are not equal, the method returns the result of the **string.CompareTo** method, which compares the two names. 

If the **names** are equal, the method compares the **Age** properties of the two dogs using the **int.CompareTo** method.

The **IEquatable** interface defines a method Equals that can be used to compare two objects of the same type for equality. The Equals method returns true if the two objects are equal, false otherwise.

```C#
// Example of the use of IEquatable

public class Dog : IEquatable<Dog>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public bool Equals(Dog other)
    {
        if (other == null)
            return false;

        if (ReferenceEquals(this, other))
            return true;

        if (GetType() != other.GetType())
            return false;

        return Name == other.Name && Age == other.Age;
    }
}
```

In the example above the **Dog** class implements the **IEquatable** interface with the type parameter of **Dog**. 

The **Equals** method is implemented to compare two instances of the **Dog** class for equality. The implementation first checks if the argument is null, and then checks if the two instances are the same **reference**. 

If the argument is of a different type or has different values for the **Name** and **Age** properties, then the two instances are not considered equal.

It is important to note that object comparison in C# can be influenced by the nature of the object being compared, and whether the object is a value type or a reference type. Value types are compared by value, whereas reference types are compared by reference. Additionally, some types, such as strings and arrays, have their own comparison methods that can be used to compare objects of that type.

### Collections

C# collections are used to store and manipulate a group of related objects. The .NET framework provides a number of collection classes that implement various interfaces such as IList, IDictionary, and ICollection.

Some of the commonly used collection classes in C# are:

- **List**: A dynamic array that can be resized and allows the addition and removal of elements.
- **Dictionary**: A collection of key-value pairs that allows fast lookup of values based on their keys.
- **HashSet**: A collection of unique elements that allows fast searching and retrieval.
- **Stack**: A collection that follows the Last-In-First-Out (LIFO) principle and allows adding and removing elements from the top.
- **Queue**: A collection that follows the First-In-First-Out (FIFO) principle and allows adding elements to the back and removing from the front.
- **LinkedList**: A collection that allows efficient insertion and removal of elements at any position.
- **ObservableCollection**: A collection that raises events when items are added, removed, or updated, making it useful for data binding scenarios.

To use a collection in C#, you need to create an instance of the collection class and then add or remove elements using its methods or properties.

**List**

In C#, **List** is one of the most commonly used collections. It is a dynamic array that can store elements of any type, such as integers, strings, objects, or other complex types. The elements in a **List** are ordered by their index, and you can access them using zero-based indexing.

**List** provides many useful methods for working with collections, such as **Add**, **Contains**, **Remove**, **Insert**, **Sort**, **IndexOf**, **ToArray**, **Clear**, and more.

```C#
// Example List

// Create a new list of integers
List<int> numbers = new List<int>();

// Add some numbers to the list
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

// Remove the second number
numbers.RemoveAt(1);

// Clear the list
numbers.Clear();
```

**Dictionary**

The **Dictionary** is a collection of **key-value pairs**, similar to a hash table. It allows you to store and retrieve elements based on a unique key associated with each element.

In a **Dictionary**, each key must be unique and can be of any data type that implements the **GetHashCode** and **Equals** methods. **Values** can also be of any data type. 

A **Dictionary** is an unordered collection, meaning that the order in which the elements are added to the collection is not guaranteed to be preserved.

Some useful methods to work with the **Dictionary** include **Add**, **TryGetValue**, **Remove**. We can also access the attributes **Keys** and **Values**.

```C#
// Example Dictionary

Dictionary<string, int> ages = new Dictionary<string, int>();

// Add key-value pairs
ages.Add("James", 25);
ages.Add("Philip", 30);
ages.Add("Peter", 35);

// Get value by key
int peterAge = ages["Peter"];
Console.WriteLine($"Peter is {peterAge} years old.");

// Check if key exists
if (ages.ContainsKey("John"))
{
    Console.WriteLine("John is in the dictionary.");
}

// Remove key-value pair
ages.Remove("James");

// Iterate over key-value pairs
foreach (KeyValuePair<string, int> kvp in ages)
{
    Console.WriteLine($"{kvp.Key} is {kvp.Value} years old.");
}
```

**HashSet**

The **HashSet** is a type of collection that represents a set of **unique values**, similar to a mathematical set. It is implemented using a hash table, which allows for fast access and lookup times.

One key feature of the HashSet collection is that it does not allow duplicates. When a value is added to the **HashSet**, the collection checks if the value already exists in the set. If it does, the value is not added again and the **HashSet** remains unchanged. If the value does not exist in the set, it is added to the set.

Some useful methods to work with the **HashSet** include **Add**, **Contains**, and **Remove**.

```C#
// Example HashSet

HashSet<int> set1 = new HashSet<int>();
HashSet<int> set2 = new HashSet<int>();

set1.Add(1);
set1.Add(2);
set1.Add(3);    // set1 = { 1, 2, 3 }

set2.Add(2);
set2.Add(3);
set2.Add(4);    // set2 = { 2, 3, 4 }

// Union
HashSet<int> union = new HashSet<int>(set1);
union.UnionWith(set2);              // union = { 1, 2, 3, 4 }

// Intersection
HashSet<int> intersection = new HashSet<int>(set1);
intersection.IntersectWith(set2);   // intersection = { 2, 3 }

// Difference
HashSet<int> difference = new HashSet<int>(set1);
difference.ExceptWith(set2);        // difference = { 1 }
```

The **HashSet** collection can be useful in scenarios where we need to store unique values and perform fast lookups. It can also be used to perform set operations such as union, intersection, and difference.

**Stack**

A **Stack** is a collection of elements that operates on the "last in, first out" (LIFO) principle. It means that the element added most recently will be the first one to be removed. It is similar to a physical stack of objects, where the last object placed on the top of the stack is the first one to be removed.

In C#, the System.Collections.Generic namespace provides a generic **Stack** class that implements the stack data structure. It provides methods like **Push**, **Pop**, **Peek**, **Clear**, and **Count**.

- **Push**: add an element to the stack.
- **Pop**: remove the most recently added element from the stack. 
- **Peek**: retrieve the most recently added element without removing it from the stack.
- **Clear**: remove all elements from the stack.
- **Count**: returns the number of elements in the stack.

```C#
Stack<string> stack = new Stack<string>();

stack.Push("apple");
stack.Push("banana");
stack.Push("cherry");
stack.Push("date");
stack.Pop();    // Removes the last entry on the stack ("date")
```

Stacks are useful in many applications, including parsing expressions and evaluating them, undo-redo functionality in applications, and in memory management.

**Queue**

A **Queue** is a data structure that implements the First-In-First-Out (FIFO) principle. It is similar to a stack, but in a queue, the first item that is added is the first one to be removed.

A **Queue** is typically used in situations where we need to process elements in the order they were added. For example, in a print spooler, documents are added to the queue in the order they are received and are printed one by one in the order they were added.

.NET provides a built-in Queue class that we can use to implement a **Queue** in C#. We can add elements to the end of the queue using the **Enqueue** method, and we can remove elements from the beginning of the queue using the **Dequeue** method. We can also peek at the first element in the queue without removing it using the **Peek** method.

Queue<string> myQueue = new Queue<string>();

// add elements to the queue
myQueue.Enqueue("apple");
myQueue.Enqueue("banana");
myQueue.Enqueue("cherry");

// remove and assigns the first element in the queue to firstItem
string firstItem = myQueue.Dequeue();

// peek at the first element in the queue without removing it
string peekItem = myQueue.Peek();

**LinkedList**

A **LinkedList** is a collection of objects that are linked together by pointers. Each object in the list contains a reference to the next object in the list, forming a chain-like structure.

**LinkedList** is a dynamic data structure, meaning that it can grow or shrink in size as needed. It is ideal for scenarios where you need to add or remove elements from the middle of the list often.

Some of the methods used to work with a **LinkedList** include **AddFirst**, **AddLast**, **AddBefore**, **AddAfter**, **Remove**, **RemoveFirst**, and **RemoveLast**.

```C#
LinkedList<int> linkedList = new LinkedList<int>();

// Add items to the list
linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddLast(3);

// Insert an item at the beginning of the list
linkedList.AddFirst(0);

// Insert an item before the second item in the list
LinkedListNode<int> node = linkedList.Find(2);
linkedList.AddBefore(node, 1);

// Remove the third item from the list
linkedList.Remove(3);
```

One thing to keep in mind when using a **LinkedList** is that each element in the list is a separate object with its own memory allocation, which can result in higher memory usage compared to other collection types.
