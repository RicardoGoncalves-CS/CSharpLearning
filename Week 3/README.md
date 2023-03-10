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
9. [Collections]()

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



### Object-Oriented Programming



### Abstraction



### Encapsulation



### Inheritance



### Polymorphism

