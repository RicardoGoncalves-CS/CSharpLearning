[Go to the root folder](https://github.com/RicardoGoncalves-CS/Sparta)

# Week 4 Notes

1. [Big O Notation]()
2. [Recursion]()
3. [Refactoring]()
4. [Design Patterns]()

### Big O Notation

In programming, Big O notation is used to describe the time complexity of an algorithm, which is the rate at which the runtime of an algorithm increases as the input size grows. Big O notation is used to provide a rough estimate of how efficient an algorithm is and how it scales with larger input sizes.

Big O notation is represented using the letter "O" followed by a function in parentheses. The function describes the upper bound of the algorithm's runtime in relation to the size of the input data. For example, O(n) means that the algorithm's runtime grows linearly with the size of the input data.

The most commonly used time complexity functions are:

- **O(1)**: The algorithm's runtime is constant, regardless of the input size. (For example, retrieving the value of a variable).
- **O(log n)**: The algorithm's runtime grows logarithmically with the input size. (For example, performing a binary search).
- **O(n)**: The algorithm's runtime grows linearly with the input size. (For example, iterating through an array of size n).
- **O(n log n)**: The algorithm's runtime grows in proportion to n times the logarithm of n. (For example, performing a merge sort)
- **O(n^2)**: The algorithm's runtime grows quadratically with the input size. (For example, a nested loop).
- **O(n^3**): The algorithm's runtime grows cubically with the input size. (For example, a nested loop nested in a loop).
- **O(2^n)**: The algorithm's runtime grows exponentially with the input size. (For example, the recursive solution to find the nth Fibonacci number).

Big O notation can also be used to describe the space complexity of an algorithm, which is the amount of memory the algorithm uses as the input size grows. The most commonly used space complexity functions are:

- **O(1)**: The algorithm uses a constant amount of memory, regardless of the input size.
- **O(n)**: The algorithm's memory usage grows linearly with the input size.

It's important to note that Big O notation describes the worst-case scenario for an algorithm, and it's possible for an algorithm to have different runtimes for different input sizes or even for the same input size. However, Big O notation is still a useful tool for comparing the efficiency of different algorithms and selecting the most appropriate one for a given problem.

### Recursion

Recursion is a powerful programming technique where a function calls itself repeatedly until a certain condition is met. In C#, recursive functions are defined like any other function, but they include one or more recursive calls to themselves.

Recursive functions have a base case, which is the condition that stops the recursion. When the base case is reached, the function stops calling itself and returns a value. The recursive calls are made until the base case is reached.

```C#
// Example of recursion

public int Factorial(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}
```

This function takes an integer **n** as input and returns the factorial of **n**. The factorial of a number is the product of all positive integers from 1 to that number. For example, the factorial of 5 is 5 x 4 x 3 x 2 x 1, which equals 120.

The function first checks if **n** is equal to 0. If it is, it returns 1 because the factorial of 0 is 1. If **n** is not equal to 0, the function calls itself with **n-1** as the input parameter, and multiplies the result with **n**. This process continues until the base case is reached (i.e., **n** becomes 0).

Recursion can be a powerful technique for solving problems that can be broken down into smaller sub-problems. However, it is important to use recursion carefully to avoid infinite loops or stack overflow errors.

### Refactoring

Refactoring is the process of improving the design and quality of existing code without changing its functionality. It involves making small, incremental changes to the code to improve its readability, maintainability, and performance. The goal of refactoring is to make the code easier to understand and modify while reducing the likelihood of introducing bugs.

There are several benefits to refactoring code. First, it makes the code more maintainable, which reduces the time and cost of making changes in the future. Second, it improves the quality of the code by removing duplicate code, reducing complexity, and improving readability. Third, it can improve the performance of the code by removing unnecessary operations and improving algorithms.

Refactoring should be done regularly as part of the development process. It is important to refactor code as soon as possible after it is written, rather than waiting until it becomes difficult to work with. This ensures that the code remains easy to understand and modify as it evolves.

There are several techniques for refactoring code. One common technique is to extract repeated code into a method or function. This reduces duplication and makes the code easier to read and maintain. Another technique is to simplify complex code by breaking it down into smaller, more manageable pieces. This can make the code easier to understand and modify.

When refactoring code, it is important to have a good test suite in place. This ensures that changes made to the code do not introduce new bugs or break existing functionality. Refactoring should be done in small, incremental steps, and each step should be tested thoroughly before moving on to the next.

Overall, refactoring is an important part of the software development process. It helps to ensure that code remains maintainable, high-quality, and performant as it evolves over time. By regularly refactoring code, developers can reduce the time and cost of making changes, improve the quality of the code, and improve the overall user experience.

### Design Patterns

Software design patterns are reusable solutions to common software design problems. They are used to provide a proven approach to solve a particular problem that arises in software development. A design pattern is a general solution that can be applied to different software problems.

Design patterns can be classified into three categories: creational, structural, and behavioral.

**Creational** patterns focus on creating objects in a way that is both flexible and efficient. They provide various ways to create objects and manage their lifecycle, ensuring that the objects are created correctly and efficiently.

**Structural** patterns are concerned with the composition of classes and objects. They define how objects are connected to one another to form larger structures. These patterns provide solutions for creating and managing relationships between objects, making it easier to modify or extend the system.

**Behavioral** patterns are used to manage communication between objects in a system. They define how objects interact with one another and how they communicate to achieve a specific goal. These patterns are useful in situations where different objects in the system need to collaborate or where the system's behavior needs to change dynamically.

Using design patterns can provide several benefits to software development. They can help to reduce complexity, improve maintainability, and provide a common language for developers to communicate with one another. Design patterns also help to standardize the way that code is written, making it easier for developers to understand and work with code written by others.

However, it is important to use design patterns judiciously. Overuse of design patterns can lead to over-engineering and increased complexity. It is essential to understand the problem that a pattern is solving before applying it to a specific situation.

Some of the design patterns include:

- **Singleton Pattern**

The Singleton pattern is a creational design pattern that ensures that a class has only one instance and provides a global point of access to that instance. It is used when there is a need to have a single instance of a class that can be accessed by other objects in the system.

The Singleton pattern is useful in situations where creating multiple instances of a class would cause problems, such as conflicting states or resource sharing issues. By restricting the instantiation of a class to a single instance, the Singleton pattern ensures that all objects in the system use the same instance of the class.

To implement the Singleton pattern, the class must have a private constructor, which prevents external objects from creating new instances of the class. The class should also have a static variable that holds the instance of the class and a static method that returns the instance.

```C#
// Example of Singleton pattern implementation

public class Singleton 
{
    private static Singleton instance = null;

    private Singleton() 
    {
        // Private constructor to prevent external instantiation
    }

    public static Singleton getInstance() 
    {
        if (instance == null) 
        {
            instance = new Singleton();
        }
        return instance;
    }
}
```

- **MVC Pattern**

The Model-View-Controller (MVC) pattern is a software architecture pattern used in building user interfaces. It separates the application logic into three interconnected components: the model, view, and controller.

The Model component represents the application's data and business logic. It handles data storage, retrieval, and manipulation. The Model component is independent of the user interface and communicates with the View and Controller components via events and notifications.

The View component is responsible for displaying the application's data to the user. It retrieves data from the Model and formats it for presentation. The View receives input from the user and forwards it to the Controller for processing.

The Controller component acts as an intermediary between the Model and View components. It receives input from the View, updates the Model based on that input, and updates the View to reflect the changes made to the Model. The Controller also handles user input validation and error handling.

The MVC pattern provides several benefits, including:
- Separation of concerns: The MVC pattern separates the application logic into distinct components, which makes it easier to maintain and modify the code.
- Code reusability: The Model component can be reused across different Views and Controllers, which can save development time.
- Testability: The separation of concerns and clear component interfaces make it easier to test each component in isolation.

```C#
// Example of MVC pattern implementation

public class Model 
{
    private string _data;

    public string GetData() 
    {
        return _data;
    }

    public void SetData(string data) 
    {
        _data = data;
    }
}

public class View 
{
    public void DisplayData(string data) 
    {
        Console.WriteLine("Data: " + data);
    }
}

public class Controller 
{
    private Model _model;
    private View _view;

    public Controller(Model model, View view) 
    {
        _model = model;
        _view = view;
    }

    public void ProcessData(string data) 
    {
        _model.SetData(data);
        view.DisplayData(_model.GetData());
    }
}
```

- **Factory Pattern**

The Factory Pattern is a creational design pattern that provides a way to create objects without specifying the exact class of object that will be created. The Factory Pattern defines an interface or an abstract class for creating objects and lets the subclasses decide which class to instantiate. This pattern provides a way to delegate the object creation logic to a separate component, called a factory.

The Factory Pattern provides several benefits:
- Encapsulates object creation: The Factory Pattern encapsulates the object creation logic in a separate component, which makes the code more modular and easier to maintain.
- Provides flexibility: By delegating object creation to a separate component, the Factory Pattern provides flexibility in changing the type of objects created without affecting the client code.
- Simplifies client code: The Factory Pattern simplifies the client code by hiding the details of object creation and only exposing a simple interface for requesting objects.

There are two common types of Factory Patterns: the Simple Factory Pattern and the Factory Method Pattern.

The Simple Factory Pattern provides a single factory method that creates objects based on a specified parameter. The Simple Factory Pattern is straightforward to implement but has limited flexibility in creating objects.

```C#
// Example of Simple Factory pattern implementation

public abstract class Vehicle 
{
    public abstract string GetVehicleType();
}

public class Car : Vehicle 
{
    public override string GetVehicleType() 
    {
        return "Car";
    }
}

public class Truck : Vehicle 
{
    public override string GetVehicleType() 
    {
        return "Truck";
    }
}

public class VehicleFactory 
{
    public Vehicle CreateVehicle(string vehicleType) 
    {
        if (vehicleType == "Car") 
        {
            return new Car();
        } 
        else if (vehicleType == "Truck") 
        {
            return new Truck();
        } 
        else 
        {
            throw new ArgumentException("Invalid vehicle type.");
        }
    }
}
```

The Factory Method Pattern provides an abstract factory class that defines an interface for creating objects. The Factory Method Pattern allows for more flexibility in creating objects than the Simple Factory Pattern.

```C#
// Example of Factory Method pattern implementation

public abstract class VehicleFactory 
{
    public abstract Vehicle CreateVehicle();
}

public class CarFactory : VehicleFactory 
{
    public override Vehicle CreateVehicle() 
    {
        return new Car();
    }
}

public class TruckFactory : VehicleFactory 
{
    public override Vehicle CreateVehicle() 
    {
        return new Truck();
    }
}
```

- **Strategy Pattern**

The Strategy Pattern is a behavioral design pattern that enables an object to dynamically change its behavior at runtime by encapsulating algorithms or strategies in separate classes and allowing the client to choose the appropriate strategy based on its needs.

The Strategy Pattern involves defining a family of algorithms, encapsulating each one in a separate class, and making them interchangeable. The client can then select the desired algorithm at runtime, based on its needs. This allows for more flexibility in changing the behavior of an object without altering its structure.

The Strategy Pattern provides several benefits:
- Encapsulates algorithms: The Strategy Pattern encapsulates the algorithms or strategies in separate classes, which makes the code more modular and easier to maintain.
- Enables runtime flexibility: By allowing the client to choose the appropriate strategy at runtime, the Strategy Pattern provides flexibility in changing the behavior of an object without altering its structure.
- Simplifies client code: The Strategy Pattern simplifies the client code by hiding the details of the algorithm and only exposing a simple interface for selecting the appropriate strategy.

```C#
// Example of Strategy pattern implementation

public interface ISortingStrategy 
{
    void Sort(int[] array);
}

public class BubbleSortStrategy : ISortingStrategy 
{
    public void Sort(int[] array) 
    {
        // Perform bubble sort algorithm
    }
}

public class QuickSortStrategy : ISortingStrategy 
{
    public void Sort(int[] array) 
    {
        // Perform quick sort algorithm
    }
}

public class Sorter 
{
    private ISortingStrategy _sortingStrategy;

    public Sorter(ISortingStrategy sortingStrategy) 
    {
        _sortingStrategy = sortingStrategy;
    }

    public void SetSortingStrategy(ISortingStrategy sortingStrategy) 
    {
        _sortingStrategy = sortingStrategy;
    }

    public void SortArray(int[] array) 
    {
        _sortingStrategy.Sort(array);
    }
}
```

Overall, the Strategy Pattern provides a flexible and modular approach to changing the behavior of an object at runtime. The choice of which strategy to use depends on the specific needs of the application and can be selected dynamically at runtime.

- **Decorator Pattern**

The Decorator Pattern is a structural design pattern that allows behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class. This pattern is useful when we want to add functionality to an object at runtime or when subclassing would result in an exponential increase in the number of classes.

The Decorator Pattern is based on the idea of wrapping an object inside another object that provides additional functionality. This wrapper object is called a decorator and it has the same interface as the object it decorates. The decorator forwards requests to the decorated object and may perform additional operations before or after forwarding the request.

```C#
// Example of Decorator pattern implementation

public interface ICar 
{
    void Drive();
}

public class Car : ICar 
{
    public void Drive() 
    {
        Console.WriteLine("Driving the car");
    }
}

public abstract class CarDecorator : ICar 
{
    protected ICar _car;

    public CarDecorator(ICar car) 
    {
        _car = car;
    }

    public virtual void Drive() 
    {
        _car.Drive();
    }
}

public class SportPackage : CarDecorator 
{
    public SportPackage(ICar car) : base(car) 
    {
    }

    public override void Drive() 
    {
        _car.Drive();
        Console.WriteLine("Adding sport package");
    }
}

public class LuxuryPackage : CarDecorator 
{
    public LuxuryPackage(ICar car) : base(car) 
    {
    }

    public override void Drive() 
    {
        _car.Drive();
        Console.WriteLine("Adding luxury package");
    }
}
```

In this example, the ICar interface defines the Drive method that every car should have. The Car class is the concrete implementation of the ICar interface.

The CarDecorator abstract class is the decorator that provides the additional functionality. It has a reference to the ICar object that it decorates and forwards the request to it.

The SportPackage and LuxuryPackage classes are concrete decorators that extend the CarDecorator class and add their own functionality to the decorated car. The Drive method of these classes first calls the Drive method of the decorated car and then adds its own behavior.

```C#
// Use of decorators

ICar car = new Car();
car = new SportPackage(car);
car = new LuxuryPackage(car);
car.Drive();
```

In this example, we first create a Car object and then wrap it with a SportPackage decorator and a LuxuryPackage decorator. When we call the Drive method on the car object, it first calls the Drive method of the Car object, then the Drive method of the SportPackage decorator, and finally the Drive method of the LuxuryPackage decorator. This allows us to add functionality to the car object at runtime without changing its structure.

In conclusion, software design patterns are a powerful tool for software development. They provide reusable solutions to common software design problems, making it easier to develop high-quality software systems. By understanding and using design patterns effectively, developers can create systems that are easier to maintain, modify, and extend.






