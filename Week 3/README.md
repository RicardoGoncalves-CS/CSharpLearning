[Go to the root folder](https://github.com/RicardoGoncalves-CS/Sparta)

# Week 3 Notes

1. [Advanced NUnit](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#advanced-nunit)
2. [Test Driven Development](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#test-driven-development)
3. [Object-Oriented Programming](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#object-oriented-programming)
4. [Abstraction](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#abstraction)
5. [Encapsulation](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#encapsulation)
6. [Inheritance](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#inheritance)
7. [Polymorphism](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%203#polymorphism)
8. [SOLID Principles]()
9. [Objects Comparison]()
10. [Collections]()

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

Encapsulation is another of the fundamental concepts of object-oriented programming, and it refers to the practice of hiding the internal details of an object and providing a clear interface for accessing and modifying its state. Encapsulation helps to protect an object's internal state from unauthorized modification, which can help to ensure the correctness and reliability of your code.

In C#, encapsulation is achieved by using access modifiers like public, protected, and internal to control access to an object's properties, fields, and methods. By making certain properties or methods private, for example, you can ensure that they can only be accessed or modified from within the object itself, which helps to prevent unintended side effects and makes your code more robust and maintainable.

**Description of access modifiers in C#**:

- **public**: The code is accessible for all classes
- **private**: The code is only accessible within the same class
- **protected**: The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
- **internal**: The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter

In addition to access modifiers, encapsulation can also be achieved through the use of properties, attributes, and other language features that help to control the way that an object's state is accessed and modified. By providing a clear interface for accessing an object's properties and methods, you can make your code more readable, understandable, and reusable.

```C#
// Example of encapsulation

public  class Animal
{
    private int _age;

    public string Name { get; set; } = "";
    public string Sound { get; private set; } = "";

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

    public Animal(string name, string sound, int age)
    {
        Name = name;
        Sound = sound;
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

    public void MakeSound()
    {
        Console.WriteLine(Sound);
    }

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

In the example above a class **Animal** was created to demonstrate principles of encapsulation.

The class has three private fields: **_age**, **_name**, and **_sound**. 

The **_age** field is accessed through a public property named Age, which has a private setter and ensures that the age is not negative. 

The **_name** and **_sound** fields are accessed through public properties **Name** and **Sound**, respectively. 

**Name** has both a getter and setter, while **Sound** has a getter and a private setter.

The class also has several public methods for interacting with an instance of the Animal class. 

**GetName()** returns the name of the animal, **Rename(string name)** sets a new name for the animal, **MakeSound()** prints out the sound the animal makes, **NewSound(string newSound)** sets a new sound for the animal, and **Birthday()** increments the age of the animal by one.

Overall, encapsulation is an essential concept in object-oriented programming, and it plays a critical role in ensuring the correctness and reliability of your code. By using encapsulation to protect an object's internal state and provide a clear interface for accessing and modifying it, you can make your code more secure, maintainable, and effective.

### Inheritance



### Polymorphism



### SOLID Principles



### Objects Comparison



### Collections
