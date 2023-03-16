[Go to the root folder](https://github.com/RicardoGoncalves-CS/Sparta)

# Week 4 Notes

1. [Big O Notation](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%204#big-o-notation)
2. [Recursion](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%204#recursion)
3. [Refactoring](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%204#refactoring)
4. [Design Patterns](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%204#design-patterns)
5. [Introduction to SQL](https://github.com/RicardoGoncalves-CS/Sparta/tree/main/Week%204#introduction-to-sql)

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

### Introduction to SQL

SQL (Structured Query Language) is a language used for managing and manipulating relational databases. It allows users to create, update, and delete data, as well as retrieve information from a database. SQL is commonly used in data-driven applications and is considered a standard language for managing databases. Its syntax is straightforward and its commands are powerful, making it a valuable tool for data analysts, developers, and database administrators.

Logical sequence (or Syntax sequence) is the order in which we write queries:
-	SELECT
-	DISTINCT
-	FROM
-	WHERE
-	GROUP BY
-	HAVING
-	ORDER BY

The Syntax Sequence is NOT the order in which each clause is actually processed by SQL. 

The Processing Sequence is the order in which each clause is processed and is as follows:
-	FROM
-	WHERE
-	GROUP BY
-	HAVING
-	SELECT
-	DISTINCT
-	ORDER BY

- **SELECT**
The first clause in a SQL query is the SELECT clause. This specifies which columns we want the query to return. It’s simple as providing a comma-separated list of column names.
```SQL
SELECT column1, column2, column3
FROM table1
```

We can change the way that column headings are presented in the output using aliases. Whilst not strictly required, it’s good practice to use the AS keyword for column aliases, to help separate the alias from the column definition.

We mostly use column aliases to improve presentation / readability. Make sure use “double quotes” and not ‘single quotes’.
```SQL
SELECT phone_number AS “Phone Number”
FROM customer
```

If we want to return all the columns in a table without having to type out every single column name, we can use an asterisk:
```SQL
SELECT *
FROM customer
```
```SQL
SELECT firstname AS "First Name", lastname AS "Last Name", birth_date AS "Date of Birth"
FROM customer
```

- **WHERE**
The **WHERE** clause is used to only retrieve specific rows from our tables.
```SQL
SELECT *
FROM product
WHERE name = ‘Chromecast’
```

The query above will only return results for products where the name field is exactly equal to ‘Chromecast’.

**NOTE**: When we work with text like ‘Chromecast’ we need to use ‘single quotes’.

The WHERE clause requires a conditional statement. Any rows for which that condition is true will be returned. The = symbol is a conditional operator that means ‘is exactly equal to’.

We should remember from when we looked at the Processing Sequence for SQL that WHERE is the 2nd clause to be processed (after FROM). After all, there’s no sense processing data that we want to filter out.
```SQL
SELECT firstName AS "First Name", lastName AS "Last Name", city AS "City"
FROM customer
WHERE city = 'Montpellier'
```

- **Comparison Operators**

The = symbol isn’t the only comparison operator we can use in our WHERE clauses.

- <	Less than
- \>	More than
- <=	Less or equal to
- \>=	More or equal to
- !=	Not equal to

```SQL
SELECT *
FROM product
WHERE available_stock < 100;
```
```SQL
SELECT *
FROM customer
WHERE city != ‘New York’;
```
```SQL
SELECT name, description, price
FROM product
WHERE price >= 100;
```

- **Multiple Comparisons**
Where clauses are not limited to single comparison.

We can use AND to return only the row for which multiple statements are true:
```SQL
SELECT *
FROM product
WHERE price < 20 AND available_stock > 1000;
```

We can use OR to return rows that match any or all of the statements:
```SQL
SELECT *
FROM customer
WHERE lastname = ‘WHITE OR lastname = ‘WILLIAMS’
```

**NOTE**: In the last example we specified the ‘lastname’ column for both comparisons. It does NOT work to type:
```SQL
-- Example that doesn’t work
WHERE lastname = ‘WHITE’ OR ‘WILLIAMS’
```
```SQL
SELECT name, price, available_stock
FROM product
WHERE price < 10 OR available_stock >= 3000
```

- **Wildcards**

If we don’t want to return only exact matches we can use wildcards, which act as substitutes for other characters. These are used in conjunction with the LIKE keyword in the WHERE clause.

-	_ : The underscore character substitutes a single character:
```SQL
SELECT *
FROM customer
WHERE firstname LIKE ‘Li_a’
```

-	% : This substitutes zero or more characters:
```SQL
SELECT *
FROM customer
WHERE firstname LIKE ‘J%’
```

-	[ABC] : Square brackets are used to specify multiple possible characters to match:
```SQL
SELECT *
FROM product
WHERE name LIKE ‘Kindle Fire [567]’
```

The example above returns results for Kindle Fire 5, Kindle Fire 6, and Kindle Fire 7.

-	[^ABC] : Negate characters in a square bracket.
```SQL
SELECT *
FROM product
WHERE name LIKE ‘Kindle Fire [^1234]’
```

There wildcards can all be combined within a single string:
```SQL
SELECT *
FROM product
WHERE name LIKE ‘[ABC]%’
```
```SQL
SELECT *
FROM product
WHERE name LIKE ‘%:%’
```

**BETWEEN**
When dealing with number in a **WHERE** clause we can use **BETWEEN** to find all the number within a certain range:
```SQL
SELECT *
FROM product
WHERE price BETWEEN 50 and 100;
```
```SQL
SELECT name, description, price, available_stock
FROM product
WHERE available_stock BETWEEN 10 and 20 AND price > 100;
```

- **IN**
The **IN** keyword allows to retrieve rows with an entry that matches any of the thing that we specify in a list (enclosed in parenthesis).
```SQL
SELECT *
FROM customer
WHERE name IN (‘James’, ‘Roger’, ‘Jean-Claude’);
```

- **NULL**
NULL in SQL indicates that there is no data.

NULL behaves in way we might not immediately expect. It is a non-value. Here are some facts about NULL:
-	NULL is not equal to 0
-	NULL is not equal to an empty string (‘’)
-	There is nothing that is equal to NULL
-	Even NULL is not equal to NULL

In order to find missing values, your first instinct might be to use something like:
```SQL
WHERE birth_date = NULL
```

This will not work as nothing can be equal to NULL. Instead we have to look for entries where the birth date IS NULL:
```SQL
SELECT *
FROM customer
WHERE birth_date IS NULL
```

To reverse the search to find entries without missing data we use IS NOT NULL instead.
```SQL
SELECT *
FROM customer
WHERE birth_date IS NOT NULL
```

- **TOP**
It’s rare that we want to see every single row and column as in particularly large databases that can potentially slow down the database for all its users.
Another way we can filter data if we just want to see a subset of the rows is by using TOP:
```SQL
SELECT TOP 5
FROM customer
```

- **ORDER BY**
ORDER BY is the last clause both in the syntax and processing sequences. It sorts the results based on the columns (or calculations) we specify.
On text it will sort alphabetically and on numbers it orders as expected.
We can specify an ascending (ASC) or descending (DESC) order. If we don’t specify it will default to ascending, but it is good practice to make it explicit.
```SQL
SELECT *
FROM customer
ORDER BY lastname ASC, firstname ASC;
```

When we use ORDER BY and TOP we get the top N rows after the data has been ordered.
```SQL
SELECT TOP 5 name, description, price
FROM product
ORDER BY price DESC
```

- **DISTINCT**
The **DISTINCT** keyword lets us remove duplicate rows from our queries.
```SQL
SELECT DISTINCT lastname
FROM customer
```SQL
SELECT DISTINCT city
FROM customer
ORDER BY city ASC
```

- **Data Manipulation**

**Concatenation**

Concatenation in SQL is easy but depends on the version of SQL being used.
For SQL Server we just put a + symbol between the columns or text we want to combine:
```SQL
SELECT firstname + ‘ ‘ + lastname AS “Full name”
FROM customer;
```

For ANSI SQL the + symbol is replaced with two pipe symbols: ||
```SQL
SELECT firstname || ‘ ‘ || lastname AS “Full name”
FROM customer;
```

It’s important to use aliases when manipulating data in the SELECT clause because the header will be ‘(No column name)’ which is not very informative.
```SQL
SELECT address || ', ' || city AS "Full Address"
FROM customer
WHERE address IS NOT NULL AND city IS NOT NULL
```

**Arithmetic**
We can manipulate numerical data using arithmetic operators:
-	Addition:	+
-	Subtraction:	-
-	Multiplication:	*
-	Division:	\
-	Modulo:	%

```SQL
SELECT name AS "Name", price AS "Price", available_stock AS "Available Stock", price * available_stock AS "Total Value"
FROM product;
```

- **CASE**
In SQL we use the **CASE** statements when we want different calculations or output depending upon the value for each row:
```SQL
SELECT name, price,
	CASE
		WHEN price < 50 THEN ‘Cheap’
		WHEN price < 100 THEN ‘Moderately Priced’
		ELSE ‘Expensive’
	END AS “Price Category”
FROM product;
```

- **Aggregation**
Aggregation is the act of merging things together into groups.
We can aggregate an entire table into a single number:
```SQL
SELECT SUM(price) AS “Total Price”
FROM product;
```

We  can aggregate multiple functions in a single query:
```SQL
SELECT SUM(available_stock) AS “Total Stock”,
	AVG(available_stock) AS “Average Stock”,
	MIN(available_stock) AS “Minimum Stock”,
	MAX(available_stock) AS “Maximum Stock”,
	COUNT(available_stock) AS “Number of products with Non-Null stock”
FROM product;
```
```SQL
SELECT SUM(available_stock * price) AS "Total Value"
FROM product;
```

**GROUP BY**
The **GROUP BY** clause groups information together and is often used in conjunction with aggregate functions.
Instead of aggregating over the entire table we can specify a column with which to group our data:
```SQL
SELECT product_category_id AS “Category ID”,
	AVG(price) AS “Average Price”,
COUNT(name) AS “Number of Products”
FROM product
GROUP BY product_category_id
```

An important rule when aggregating or grouping in SQL is that everything in the **SELECT** clause must be an aggregate or appear in the **GROUP BY** clause.
Whenever we use aggregation or grouping everything in the **SELECT** clause has to be aggregated or grouped.
```SQL
SELECT city AS "City", COUNT(city) AS "Customer Count"
FROM customer
GROUP BY city
ORDER BY "Customer Count" DESC, city
```

**HAVING**
The **HAVING** clause is used when we wan to filter based on the result of aggregation.
```SQL
SELECT product_category_id AS “Category ID”,
	AVG(price) AS “Average Price”
FROM product
GROUP BY product_category_id
HAVING AVG(price) < 200;
```

**HAVING** is different from **WHERE**. **WHERE** is used to filter rows in the original table, whilst **HAVING** is used to filter based on aggregation. It is possible to use both together:
```SQL
SELECT product_category_id AS “Category ID”,
	AVG(price) AS “Average Price”
FROM product
WHERE product_category_id IS NOT NULL
GROUP BY product_category_id
HAVING AVG(price) < 200;
```
```SQL
SELECT product_category_id AS "Category ID",
    MAX(price) AS "Maximum Price"
FROM product
GROUP BY product_category_id
HAVING MIN("Category ID" < 100)
ORDER BY "Category ID" ASC
```

- **JOIN**
The **JOIN** keyword combines tables together by matching on rows. We specify two tables, and a rule for joining them. This will usually be that values in a column in Table 1 should be the same as values in a column in Table 2. Whenever there’s a match a match in these columns, we combine those rows.
**JOIN** statements are part of the **FROM** clause.

For some types of join, it is important to understand which is the “Left Table” and which is the “Right Table”. The Left Table will be the first table specified, and we join the Right Table on the Left Table.

When we join tables we might end up with multiple columns with the same name. To disambiguate in these situations we use a full stop: table.column, where table is the name of the table the column belongs to, and column is the name of the column. This is not strictly necessary when dealing columns with unique names, but its good practice.

**JOIN TYPES:**

**LEFT JOIN** (or LEFT OUTER JOIN) will return ALL rows in the Left Table, and only return rows from the right table that match with rows in the Left Table.
```SQL
SELECT *
FROM LeftTable
LEFT JOIN RightTable
ON LeftTable.KeyColumn = RightTable.KeyColumn
```

**RIGHT JOIN** (or RIGHT OUTER JOIN) will return ALL rows in the Right Table, and only return rows from the Left Table that match with rows in the Right Table.
NOTE: Right Joins are very rare, as ever single Right Join could be refactored to work as a Left Join, which is more intuitive and easier to understand. Right Joins should be avoided unless there is a good reason for it.
```SQL
SELECT *
FROM LeftTable
RIGHT JOIN RightTable
ON LeftTable.KeyColumn = RightTable.KeyColumn
```

**INNER JOIN** (or simply JOIN) will return rows from each table ONLY if there is a match in the other table.
```SQL
SELECT *
FROM LeftTable
INNER JOIN RightTable
ON LeftTable.KeyColumn = RightTable.KeyColumn
```

**OUTER JOIN** (or FULL OUTER JOIN) will return ALL rows from each table, regardless of whether there is a match with the other table.
```SQL
SELECT *
FROM LeftTable
OUTER JOIN RightTable
ON LeftTable.KeyColumn = RightTable.KeyColumn
```

For LEFT, RIGHT and OUTER joins, whenever there is not a matching row in one of the tables, the missing values will be represented by NULL.
```SQL
SELECT FIRSTNAME, COURSENAME
FROM student
INNER JOIN course
ON student.course_id = course.id
```

- **Tables Aliases**
Typing out each table name multiple times can become cumbersome. Table aliases allow us to create references to make accessing them easier as faster. It’s standard practice to use the initials of the table name, adding letters in situations where two tables share the same initials. E.g., products and prices might use aliases pro and pri. We can use the AS keyword but it’s more common to skip this and type alias immediately after the table name.
```SQL
SELECT s.firstname, c.coursename
FROM student s
INNER JOIN course c
ON s.course_id = c.id
```
```SQL
SELECT s.firstname AS "First Name", c.coursename AS "Course"
FROM student s
LEFT JOIN course c
ON s.course_id = c.id
```

- **Multiple Joins**

It is possible to perform multiple joins within a single query. We simply add the next join immediately afterwards. Each new join can join on to the original table specified at the start of the FROM clause, or any table that has already been joined on to this table.
```SQL
SELECT *
FROM table1 t1
JOIN table2 t2
	ON t1.id = t2.id
JOIN table3 t3
	ON t1.id = t3.id
```
```SQL
SELECT pur.date AS "Date", UPPER(c.firstname) || ' ' || UPPER(c.lastname) AS "Customer", pro.name AS "Product", pc.name AS "Product Category"
FROM purchase_order pur
JOIN customer c
    ON pur.customer_id = c.customer_id
JOIN order_product o
    ON pur.order_id = o.order_id
JOIN product pro
    ON o.product_id = pro.product_id
JOIN product_category pc
    ON pro.product_category_id = pc.product_category_id
ORDER BY pur.date ASC
```

**SQL Practical exercise**

Display all tables in a database:
```SQL
SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'
```

1.1	Write a query that lists all Customers in either Paris or London. Include Customer ID, Company Name and all address fields.
```SQL
SELECT CustomerID AS "Customer ID", CompanyName AS "Company", Address +  ', ' + PostalCode + ', ' + City + ', ' + Country AS "Address"
FROM Customers
WHERE City IN ('Paris', 'London')
```

1.2 List all products stored in bottles.
```SQL
SELECT *
FROM Products
WHERE QuantityPerUnit LIKE '%bottles%'
```

1.3 Repeat question above but add in the Supplier Name and Country.
```SQL
SELECT p.*, s.CompanyName AS "Supplier", s.Country
FROM Products p
JOIN Suppliers s
	ON p.SupplierID = s.SupplierID
WHERE QuantityPerUnit LIKE '%bottles%'
```

1.4 Write an SQL Statement that shows how many products there are in each category. Include Category Name in result set and list the highest number first.
```SQL
SELECT c.CategoryName AS "Category", COUNT(p.ProductName) AS "Products per Category"
FROM Products p
JOIN Categories c
	ON p.CategoryID = c.CategoryID
GROUP BY c.CategoryName
ORDER BY “Products per Category” DESC
```

1.5 List all UK employees using concatenation to join their title of courtesy, first name and last name together. Also include their city of residence.
```SQL
SELECT TitleOfCourtesy + ' ' + FirstN ame + ' ' + LastName AS "Name", City
FROM Employees
```

1.6 Count how many Orders have a Freight amount greater than 100.00 and either USA or UK as Ship Country.
```SQL
SELECT COUNT(OrderID) AS "Number of Orders"
FROM Orders
WHERE Freight > 100 AND ShipCountry IN ('USA', 'UK')
```

1.7 Write an SQL Statement to identify the Order Number of the Order with the highest amount of discount applied to that order.
```SQL
SELECT TOP 1 o.OrderID AS "Order Number"
FROM "Order Details" od
JOIN Orders o
	ON od.OrderID = o.OrderID
GROUP BY o.OrderID, Discount
ORDER BY Discount DESC
```

1.8 List all Employees from the Employees table and who they report to. No Excel required.
```SQL
SELECT e1.FirstName + ' ' + e1.LastName AS "Name", e2.FirstName + ' ' + e2.LastName AS "Reports to"
FROM Employees e1, Employees e2
WHERE e1.ReportsTo = e2.EmployeeID
```

**Create Spartans Table**

```SQL
CREATE TABLE Spartans (
	ID int IDENTITY(1, 1) PRIMARY KEY,
	Title varchar(255),
	FirstName varchar(255) NOT NULL,
	LastName varchar(255) NOT NULL,
	University varchar(255),
	Course varchar(255),
	Mark decimal
)

INSERT INTO Spartans 
	(FirstName, LastName)
VALUES 
	('Philip', 'Windridge'),
	('Peter', 'Bellaby'),
	('Alin-George', 'Rusu'),
	('Byron', 'Esson'),
	('Chun Kai', 'Ho'),
	('Connor', 'Dawson'),
	('Henry', 'Shapland'),
	('Jack', 'Linstead'),
	('Luke', 'Pinder'),
	('Max', 'Hegarty'),
	('Mohammed Ali', 'Butt'),
	('Mubashir', 'Ahmad'),
	('Ricardo', 'Goncalves'),
	('Ruya', 'Kumru-Holroyd'),
	('Valentin', 'Gaudeau');
```




