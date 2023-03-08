[Go to the root folder](https://github.com/RicardoGoncalves-CS/Sparta)

# Week 2 Notes

1. [Using Visual Studio](https://github.com/RicardoGoncalves-CS/Sparta/blob/main/Week%202/README.md#1-using-visual-studio)
2. [Unit Testing](https://github.com/RicardoGoncalves-CS/Sparta/blob/main/Week%202/README.md#2-unit-testing)
3. [Operators & Control flow](https://github.com/RicardoGoncalves-CS/Sparta/blob/main/Week%202/README.md#3-operators--control-flow)
4. [Exceptions](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%202#4-exceptions)
5. [Data Types](https://github.com/RicardoGoncalves-CS/Sparta/blob/main/Week%202/README.md#4-data-types)
6. [Memory Model](https://github.com/RicardoGoncalves-CS/Sparta/blob/main/Week%202/README.md#5-memory-model)

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

-	**[Test]**: Marks a method that represents a test.
-	**[TestCase]**: Marks a method with parameters as a test and provides inline arguments.

Many other attributes can be found at [NUnit attributes webpage](https://docs.nunit.org/articles/nunit/writing-tests/attributes.html).

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
-	**Band 1** - 0 to 4: Evening
-	**Band 2** - 5 to 11: Morning
-	**Band 3** - 12 to 17: Afternoon
-	**Band 4** - 18 to 23: Evening

When writing tests, it is good practice to test 3 different values for each band. These values should be:
-	*Upper bound*: highest value in that band.
-	*Lower bound*: lowest value in that band.
-	*Middle value*: a value between the upper and lower bounds.

If we want to test Band 3 of the example above we would test for the values of 12, 17, and any value between, such as 14.

### 3. Operators & Control flow

Operators are symbols or keywords that perform specific operations on one or more operands.

Some commonly used operators in C#:

1.	**Arithmetic Operators**:
-	Addition: +
-	Subtraction: -
-	Multiplication: *
-	Division: /
-	Modulus: %

2.	**Comparison Operators**:
-	Equal to: ==
-	Not equal to: !=
-	Greater than: >
-	Less than: <
-	Greater than or equal to: >=
-	Less than or equal to: <=

3.	**Logical Operators**:
-	And: &&
-	Or: ||
-	Not: !

4.	**Bitwise Operators**:
-	Bitwise AND: &
-	Bitwise OR: |
-	Bitwise XOR: ^
-	Bitwise complement: ~
-	Left shift: <<
-	Right shift: >>

5.	**Assignment Operators**:
-	Simple assignment: =
-	Addition assignment: +=
-	Subtraction assignment: -=
-	Multiplication assignment: *=
-	Division assignment: /=
-	Modulus assignment: %=
-	Bitwise AND assignment: &=
-	Bitwise OR assignment: |=
-	Bitwise XOR assignment: ^=
-	Left shift assignment: <<=
-	Right shift assignment: >>=

```C#
// Assigning values to a variable
Int x = 5

// increment operator (++) increases the value by 1.
// decrement operator (--) decreases the value by 1.

// post increment operator: x is assigned before increment
Int a = x++
// here 'a' has the value 5 and 'x' has the value 6

// pre increment operator: x is incremented before assignment
Int b = ++x
// here 'b' has the value 7 and 'x' has the value 7

Int c = x—
// here 'c' has the value 7 and 'x' has the value 6
```

**var** is a placeholder for the data type. The compiler evaluates the data types in the operation to infer the var type.

```C#
// 'c' data type will be int
var c = 10 / 3;	    

// 'd' data type will be double
var d = 9.5 / 4;	
```

**&& / || and  & / |** (Logical AND / OR)

```C#
// Example
string luke = "luke"
string alin = null;

// The following example will evaluate both condition
bool bothStartWithA = luke.StartsWith('a') & alin.StartsWith('a');

//The following example will not evaluate the second condition because it asserts that the first condition is false thus the overall evaluation defaults to false
bool bothStartWithA = luke.StartsWith('a') && alin.StartsWith('a');
```

**Ternary statement** a ? b : c

bool expression ? executed if true : executed if false
```C#
// Example: If mark is greater or equal to 65 assigns “Pass” to grade, otherwise assigns “Fail”
int mark = 30;
string grade = mark >= 65 ? “Pass” : “Fail”;
```

Ternary statements can take more than 2 bool expressions:
```C#
int mark = 90;
string betterGrade = mark >= 65 ? mark >= ? “Distinction” : “Pass” : “Fail”;
```

**Switch statement**

A switch statement is a control statement that allows you to test a variable or expression against multiple possible values and execute different code blocks depending on which value matches.

If none of the cases match the expression, then the code block associated with the **default** case is executed (if present).

The switch statement can be a useful alternative to using multiple if-else statements when you need to test a single variable or expression against multiple possible values. It can help to make your code more readable and easier to maintain, especially when dealing with a large number of possible cases.

```C#
switch (expression)
{
    case value1:
        // code block to be executed if expression matches value1
        break;
    case value2:
        // code block to be executed if expression matches value2
        break;
    ...
    default:
        // code block to be executed if none of the cases match
        break;
}
```

**Loops**

Loops, or iterations refer to the repeated execution of a block of code until a certain condition is met. Iterations are used to automate repetitive tasks and make your code more efficient and less error-prone.

Types of loops:
```C#
// Example: return the highest value in a list of integers
public static class LoopTypes
{
    internal static string HighestDoWhileLoop(List<int> nums)
    {
        int max = Int32.MinValue;
        int counter = 0;

        do
        {
            if (nums[counter] > max) max = nums[counter];
            counter++;
        } while (counter < nums.Count);

        return max.ToString();
    }

    internal static string HighestForeachLoop(List<int> nums)
    {
        // find the highest number in nums
        int max = Int32.MinValue;

        foreach(int num in nums)
        {
            if (num > max) max = num;
        }

        return max.ToString();
    }

    internal static string HighestForLoop(List<int> nums)
    {
        int max = Int32.MinValue;

        for(int i = 0; i < nums.Count; i++)
        {
            if (nums[i] > max) max = nums[i];
        }

        return max.ToString();
    }

    internal static string HighestWhileLoop(List<int> nums)
    {
        int max = Int32.MinValue;
        int counter = 0;

        while (counter < nums.Count)
        {
            if (nums[counter] > max) max = nums[counter];
            counter++;
        }

        return max.ToString();
    }
}
```
### 4. Exceptions



### 5. Data Types



### 6. Memory Model



