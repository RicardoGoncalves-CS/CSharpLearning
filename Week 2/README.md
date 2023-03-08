[Go to the root folder](https://github.com/RicardoGoncalves-CS/Sparta)

# Week 2 Notes

1. [Using Visual Studio]()
2. [Unit Testing]()
3. [Operators & Control flow]()
4. [Data Types]()
5. [Memory Model]()

### 1. Using Visual Studio

During this lesson we learned about Visual Studio and .NET. We also explored some of Visual Studio features and how to use it.

[Official Visual Studio website](https://visualstudio.microsoft.com/)

Visual Studio is an Integrated Development Environment (IDE) developed by Microsoft and is the tool we are going to use throughout our Sparta training to write code.

Visual Studio is a tool that allows developers to write, debug, and deploy code across a variety of programming languages and platforms. It also provides features that help developers to write high-quality code such as refactoring, IntelliSense, and debugging tools. Add-ons can be used to enhance its functionality by adding support for additional programming languages, frameworks, and tools.

Visual Studio supports many popular frameworks, including .NET, .NET Core, and ASP.NET.

.NET is a software development platform developed by Microsoft which provides a platform for building and running applications on various operating systems, including Windows, Linux, and macOS. It consists of a set of libraries, runtime environments, and tools that developers can use to create applications.

The original implementation of the .NET was .NET Framework, which was released in 2002, and only provided the tools to develop Windows applications.

.NET Core is an open source, light-weight and modular implementation of .NET framework released in 2016,  which allows cross-platform development for building and running applications on Windows, Linux, and macOS.

.NET 5 was released in 2016 and was the product of unification of .NET Framework and .NET Core. It provides a single, cross-platform runtime environment for building and running applications on various platforms and devices, including desktop, web applications, mobile and cloud-based services.

[.NET official website](https://dotnet.microsoft.com/en-us/)

### 2. Unit Testing

Unit testing is a software testing technique in which individual units or components of a software application are tested in isolation from the rest of the system. The purpose of unit testing is to validate that each unit functions as intended, and to identify and fix defects early in the development process. By isolating components of the software application and testing them individually helps to ensure it works as expected.

In Unit testing the developer writes test cases to test specific functionality of a unit and executing those test cases using an automated testing framework. The framework provides the tools for defining and running tests, and reporting the test results, among other features.

During this training we will be using NUnit which is an open-source unit testing framework for .NET applications. It allows to developers to write and run automated tests in C# and other programming languages supported by .NET, and can be integrated with many development environments such as Visual Studio.

[NUnit official website](https://nunit.org/)

The 3 A’s of unit testing

-	*Arrange*: here we set up the necessary preconditions for the test, including any required objects, variables, or data that the test needs in order to execute.
-	*Act*: The functionality being tested in executed.
-	*Assert*: The result of the functionality being tested is compared to the expected result. The test is considered to have passed if the both results match, otherwise the test is considered to have failed.

```C#
// NUnit Test example

[Test]
public void Given5_MyMethod_ReturnGoodMorning()
{
// Arrange
int input = 5;
string expected = "Good morning!";

// Act
string result = Program.MyMethod(input);

// Assert
Assert.That(result, Is.EqualTo(expected));
}
```

NUnit provide many attributes that can be used to write tests such as:

-	[Test]: Marks a method that represents a test.
-	[TestCase]: Marks a method with parameters as a test and provides inline arguments.

[NUnit attributes webpage](https://docs.nunit.org/articles/nunit/writing-tests/attributes.html)

```C#
// NUnit TestCase example

[TestCase(9)]
[TestCase(10)]
public void GivenTimes_MyMethod_ReturnGoodMorning(int input)
{
// Arrange
string expected = "Good morning!";

// Act
string result = Program.MyMethod(input);

// Assert
Assert.That(result, Is.EqualTo(expected));
}
```

We can also test if a certain situation triggers an Exception:

```C#
// NUnit TestCase example for Exceptions

[TestCase(-10)]
[TestCase(25)]
public void GivenOutOfBoundTimes_MyMethod_ThrowsArgumentOutOfRangeException(int input)
{
Assert.That(() => Program.MyMethod(input), Throws.TypeOf<ArgumentOutOfRangeException>());
}
```

When creating tests, we should identify the bands that are being tested. 

For example assuming that a hours of a day are 0 to 23 and we want to return different greeting depending on the time of the day we can divide it in the following bands:
-	Band 1 - 0 to 4: Evening
-	Band 2 - 5 to 11: Morning
-	Band 3 - 12 to 17: Afternoon
-	Band 4 - 18 to 23: Evening

When writing tests, it is good practice to test 3 different values for each band. These values should be:
-	Upper bound: highest value in that band.
-	Lower bound: lowest value in that band.
-	Middle value: a value between the upper and lower bounds.

If we want to test Band 3 of the example above we would test for the values of 12, 17, and any value between, such as 14.

### 3. Operators & Control flow



### 4. Data Types



### 5. Memory Model


---

# Week 2 repository overview

This folder contains the following subfolders:

- 1_UsingVisualStudio
- 2_UnitTesting
- 3_OperatorsAndControlFlow
- 4_DataTypes
- 5_MemoryModel
- 6_Week2_MiniProject

# UNDER CONSTRUCTION

## Week 2

This folder contains the following folders:

- UsingVisualStudio
- UnitTestLesson
- OperatorsAndControlFlow
- 02a_UnitTestLab
- 02b_TestFirstExercises

### UsingVisualStudio

This folder was created as a test to explore how to use some Visual Studio features and how to use the terminal inside Visual Studio to work with git.

### UnitTestLesson

This folder is the result of the lesson on Unit Testing. 

*UnitTestApp* and *UnitTestTest* files were created during the lesson to learn about how to perform Unit Testing on the code.

*UnitTestLab* and *UnitTestLabTest* files were created as the result of the task that can be found in *02a_UnitTestLab*.

### 02b_TestFirstExercises

Contain the files used during the lesson for a task which consisted in creating some methods implementation given the method description and pass the given test cases.

### 02a_UnitTestLab

Contain the files with the information about a task, which the solution can be found in the *UnitTestLesson* folder.

### OperatorsAndControlFlow

Contain the files created during the lesson on Operators and Control flow.
