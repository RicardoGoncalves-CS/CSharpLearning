[Go to the root folder](https://github.com/RicardoGoncalves-CS/Sparta)

# Week 4 Notes

1. [Big O Notation]()
2. [Recursion]()

### Big O Notation

In programming, Big O notation is used to describe the time complexity of an algorithm, which is the rate at which the runtime of an algorithm increases as the input size grows. Big O notation is used to provide a rough estimate of how efficient an algorithm is and how it scales with larger input sizes.

Big O notation is represented using the letter "O" followed by a function in parentheses. The function describes the upper bound of the algorithm's runtime in relation to the size of the input data. For example, O(n) means that the algorithm's runtime grows linearly with the size of the input data.

The most commonly used time complexity functions are:

- O(1): The algorithm's runtime is constant, regardless of the input size. (For example, retrieving the value of a variable).
- O(log n): The algorithm's runtime grows logarithmically with the input size. (For example, performing a binary search).
- O(n): The algorithm's runtime grows linearly with the input size. (For example, iterating through an array of size n).
- O(n log n): The algorithm's runtime grows in proportion to n times the logarithm of n. (For example, performing a merge sort)
- O(n^2): The algorithm's runtime grows quadratically with the input size. (For example, a nested loop).
- O(n^3): The algorithm's runtime grows cubically with the input size. (For example, a nested loop nested in a loop).
- O(2^n): The algorithm's runtime grows exponentially with the input size. (For example, the recursive solution to find the nth Fibonacci number).

Big O notation can also be used to describe the space complexity of an algorithm, which is the amount of memory the algorithm uses as the input size grows. The most commonly used space complexity functions are:

- O(1): The algorithm uses a constant amount of memory, regardless of the input size.
- O(n): The algorithm's memory usage grows linearly with the input size.

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

This function takes an integer n as input and returns the factorial of n. The factorial of a number is the product of all positive integers from 1 to that number. For example, the factorial of 5 is 5 x 4 x 3 x 2 x 1, which equals 120.

The function first checks if n is equal to 0. If it is, it returns 1 because the factorial of 0 is 1. If n is not equal to 0, the function calls itself with n-1 as the input parameter, and multiplies the result with n. This process continues until the base case is reached (i.e., n becomes 0).

Recursion can be a powerful technique for solving problems that can be broken down into smaller sub-problems. However, it is important to use recursion carefully to avoid infinite loops or stack overflow errors.
