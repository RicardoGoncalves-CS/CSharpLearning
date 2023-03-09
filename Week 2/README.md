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

**Assignment, increment and decrement**

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

**Difference between && / &** (Logical AND)

```C#
// Example
string luke = "luke"
string alin = null;

// The following example will evaluate both condition
bool bothStartWithA = luke.StartsWith('a') & alin.StartsWith('a');

//The following example will not evaluate the second condition because it asserts that the first condition is false thus the overall evaluation defaults to false
bool bothStartWithA = luke.StartsWith('a') && alin.StartsWith('a');
```

- **Ternary statement** 

a ? b : c

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

- **Switch statement**

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

- **Loops**

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
        
        // do-while loop
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
        
        // foreach loop
        foreach(int num in nums)
        {
            if (num > max) max = num;
        }

        return max.ToString();
    }

    internal static string HighestForLoop(List<int> nums)
    {
        int max = Int32.MinValue;

        // for loop
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

        // while loop
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

An exception is an error or unexpected event that occurs during the execution of a program that interrupts its normal flow. Exceptions can be caused by various factors, such as invalid input data, system errors, or unexpected conditions.

When an exception happens, the program will stop running and display an error message, unless it is handled. By using exceptions handling developers can write code that is more robust and less likely to crash.

In C#, exceptions are represented by objects of the Exception class or one of its derived classes. To handle exceptions we can use a try-catch block:

```C#
// Example of a try-catch block

// Trying to read a file that doesn't exist.
try
{
    var text = File.ReadAllText("HelloWorld.txt");  
    Console.WriteLine(text);
}
// Exceptions will be thrown in order of specificity. In this code only FileNotFoundException will be thrown
catch (FileNotFoundException e) 
{
    Console.WriteLine("File Not Found Exception");
    Console.WriteLine(e.Message);
}
// General exceptions are not advised. Exceptions are useful to informs the developer what happened allowing to implement specific types of exceptions.
catch (Exception e) 
{
    Console.WriteLine("Exception");
    Console.WriteLine(e.Message);
}
// finally always execute regardless of whether an exception occurred
finally 
{
    Console.WriteLine("I always run");
}
```

When an exception occurs, an instance of the appropriate exception class is created, and the program's execution is transferred to the nearest catch block that can handle the exception.

The order of exception types in the catch blocks must be from more specific to less specific. That means that an ArgumentException should come before a general Exception for example.

### 5. Data Types

C# is both a strongly and statically typed language. This means that the programmer must declare the data type of each variable, and the compiler checks that the declared types match the data being assigned to the variable before generating the executable code. As a result, C# is type safe, which prevents changing the data type of a variable after it has been declared. C# is also memory safe, as the computer can determine the necessary memory allocation for each variable.

Some of the most commonly used numeric data types in C#:
-	**byte**: 8-bit unsigned integer (0 to 255).
-	**sbyte**: 8-bit signed integer (-128 to 127).
-	**short**: 16-bit signed integer (-32,768 to 32,767).
-	**ushort**: 16-bit unsigned integer (0 to 65,535).
-	**int**: 32-bit signed integer (-2,147,483,648 to 2,147,483,647).
-	**uint**: 32-bit unsigned integer (0 to 4,294,967,295).
-	**long**: 64-bit signed integer (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807).
-	**ulong**: 64-bit unsigned integer (0 to 18,446,744,073,709,551,615).
-	**float**: 32-bit floating-point number.
-	**double**: 64-bit floating-point number.
-	**decimal**: 128-bit floating-point number.

Other data types:
-	**bool**: true or false.
-	**char**: represents a Unicode character.
-	**string**: represents a sequence of Unicode characters.

Composite data types:
-	**Arrays**: collection of elements of the same data type.
-	**Structs**: value type that can contain fields and methods.
-	**Classes**: reference type that can contain fields, properties, methods, and can be used to create objects.

**NOTE**: In C# data types are implemented as objects.

**Overflow and underflow**

Overflow and underflow refers to the event were a data type goes over its maximum or under its minimum value. When that occurs the value jumps to the opposite side of the range of values that data type support.

```C#
// Example of overflow

// In the example below exampleVariable of type byte is assigned the value 255 (the maximum value for a byte)
// By adding 1 the value of exampleVariable jumps to the first value on the opposite range of values for this data type and will be holding the value 0
Byte exampleVariable = 255;
exampleVariable += 1;
```

We can use the keyword **checked** to create a block where overflows and underflows occur which will throw an exception if that happens, or execute the operation normally if not.

```C#
// Example of a checked block

// It will throw an exception to stop the overflow from happening
Checked
{
	Byte exampleVariable = 255;
	exampleVariable += 1;
}
```

Suffixes in values can be used to enforce a specific data type. Some suffix examples include:

```C#
uint integralNumber = 10u;
float floatNumber = 10.5f;
double doubleNumber = 10.5d;
decimal decimalNumber = 10.5m;
ulong  longNumber = 10_000_000_000_000_000ul;
```

**NOTE**: in the code snippet above I used underscores. This are ignored but can help with readability.

```C#
// Example of suffix use

float a = 2 / 5;
float b = 2 / 5f;

// In the example above ‘a’ is assigned the value 0 because a division of two integers will result in an integer value (which in this case will be 0) even if the variable the value is assigned to is a float.
// ‘b’ is assigned the value 0.4 because the suffix ‘f’ enforces the data type of 5 to be a float, and the result of a division between an integer and a float value will result in a float.
```

**Type conversion**

Type conversion refers to the act of converting a data type value to another data type. When converting data types, it’s important that the target data type can handle the data being converted. When converting data types, we can lose some data so is important to take some considerations.


**Safe conversion** is the process of converting data types in a way that minimizes loss of data or errors.

Type conversion can be implicit or explicit.

Implicit type conversion occurs when one data type is automatically converted into another without special casting syntax and no data is lost during the conversion process. Usually for that to be possible the type being converted from should be smaller in size than the target data type, and they are both signed or unsigned (as the ranges are different).

For example, is safe to convert from:
-	**int** to **long**
-	**short** to **int**
-	**int** to **double**
-	**uint** to **ulong**

But not from:
-	**long** to **int**
-	**double** to **short**
-	**int** to **uint**

```C#
// Example

int originSafe = 1000;
long targetSafe;

targetSafe = originSafe;
```

[Type conversion tables in .NET](https://learn.microsoft.com/en-us/dotnet/standard/base-types/conversion-tables)

**Unsafe conversion** using the casting operator:

```C#
double x = 3.14159265359;
float y = (float)x;
```

**The Convert class**

We can use the **Convert** class to convert data types. It does background checks and throw an exception if an error occurs.

```C#
// Example

long a = 54444444;
int b = Convert.ToInt32(a);
```

**Converting strings to numbers**

In C# we can use **Parse** and **TryParse** methods to convert a string representation of a value into its corresponding data type.

**Parse** takes a string argument and attempts to convert to the specified data type. If the string cannot be converted an exception is thrown.

**TryParse** returns a Boolean value indicating if whether the conversion was successful or not. In case the conversion was successful the method also returns the converted value as an output parameter.

```C#
// Example

string numString = "2023";
int num;

// Using Parse
num = int.Parse(numString);
Console.WriteLine(num);

// Using TryParse
if (int.TryParse(numString, out num))
{
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Could not convert string to integer.");
}
```

**Strings**

Strings represent a sequence of characters. Characters on a string are indexed and can be accessed individually using their index.

In C# strings can be formatted using methods, concatenation, and interpolation. C# also provides the StringBuilder class which helps to build strings.

Some of string methods include:
-	ToUpper: changes the characters in a string to upper case.
-	ToLower: changes the characters in a string to lower case.
-	Replace: allows to replace a character in a string with another.
-	Trim: eliminate blank spaces in a string.

[Comprehensive list of string methods](https://learn.microsoft.com/en-us/dotnet/api/system.string.clone?view=net-7.0)

**Concatenation** allows to join strings together and uses the + symbol to do so:

```C#
// Example of concatenation
string fName = “James”;
string lName = “Bond”;

string fullName = fName + “ “ + lName;
```

**Interpolation** uses the $ symbol before the first “ and uses brackets to hold variables whose values will be inserted in place. The brackets also allows us to do in-place operations. For example {10 / 2} would be formatted as “5”.

```C#
// Example of interpolation
string fName = “James”;
string lName = “Bond”;

string fullName = $”{fName} {lName}”;
```

We can use the symbol @ to print literal strings instead of the formatted version:
```C#
// Example of literals
string fName = “James”;
string lName = “Bond”;

string fullName = @”{fName} {lName}”;
```

We can also use certain syntax to format the string such as **\n** for new line, and **\t** for tab.

**StringBuilder**

The StringBuilder class is a more efficient way to manipulate strings compared to concatenation. When we concatenate strings using the + operator a new string object is created in memory for each concatenation.

StringBuilder allows to build up a string by appending string fragments without creating new string objects each time.

```C#
// Example of StringBuilder

StringBuilder sb = new StringBuilder();

sb.Append("Hello");
sb.Append(" ");
sb.Append("world!");
sb.Replace(“world”, “everyone”);

string result = sb.ToString();   // result = "Hello everyone!"
```

### 6. Memory Model

The memory model is the set of rules that governs how a program uses memory. It ensures that different threads in a program can safely access shared memory without interfering with each other or causing unexpected behaviour.

There are two main regions in the memory model:
- Stack: stores local variables
- Heap: store objects and other dynamically allocated data such as strings and arrays.

The C# memory model includes the following concepts:
- Value types: these are stored on the stack and contain the actual data values. Value types include **ints**, **floats**, and **bools**.
- Reference types: are stored on the heap and contain a reference to the memory location of the object. The reference is stored in the stack whilst the actual values are stored in the heap.
- Garbage collection: is used to automatically free memory that is no longer in use. It periodically scans the heap to identify objects that are no longer being used, and frees the memory associated with those objects.

**Value types**

Value types are copied:

```C#
// Example – Both variables store the value 10 in the stack

int ticket = 10;
var price = ticket; 
```

**Reference types**

Reference types copy the reference to the address in the heap that contains the value:

```C#
// Example – Both variables share the same reference to the memory address. By changing the value in one will change the value in both, as they share the same reference to the values in memory.
// In the end of the following operation both variables will point to the values { 1, 10, 3 } stored in the heap.

int[] myNumbers = { 1, 2, 3 }
var ourNumbers = myNumbers;
ourNumbers[1] = 10;
```

**ref** and **in** keywords

The **ref** keywords is used to pass a variable by reference which means that the method that receives the parameter can modify the original value of the argument.

The **in** keyword is also used to pass a variable by reference but as read-only, so the method that receives the parameter cannot modify the original value.

```C#
// Example of passing by reference

void refMethod(ref int myVariable)
{
 myVariable = myVariable * 2;
}

void inMethod(in int myVariable)
{
Console.WriteLine(myVariable);
}

int main()
{
int value = 10;
refMethod(ref value);   // value is 10
inMethod(in value);  	// outputs "10"
}
```

**out** keyword

The **out** keyword is used in method parameter declarations to indicate that the parameter is an output parameter.

When a parameter is marked with the **out** keyword the method must always assign its value before returning.

```C#
// Example of the out keyword use

public void Double(int input, out int output)
{
    output = input * 2;
}

int input = 10;
int output;
Double(input, out output);
Console.WriteLine(output); 	// Output: 20
```
