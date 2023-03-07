namespace PairProgrammingTDD;

public class Fibonacci
{
    static void Main()
    {
        Console.WriteLine(FibonacciProblem());
    }

    /* Step 1
    public static int FibonacciSequence(int input)
    {
        return 1;
    }
    */

    /* Step 2
    public static int FibonacciSequence(int input)
    {
        return input;
    }
    */

    /*
    public static int FibonacciProblem(int input)
    {
        int firstValue = 1;
        int secondValue = 2;
        int current = firstValue + secondValue;
        int sum = secondValue;

        if (input == 1) return 0;
        if (input == 2) return secondValue;

        for (int i = 3; i < input; i++)
        {
            firstValue = secondValue;
            secondValue = current;
            current = firstValue + secondValue;
            if(current % 2 == 0) sum += current;
        }
        return sum;
    }
    */

    /*
    public static int FibonacciProblem8()
    {
        int firstValue = 1;
        int secondValue = 2;
        int current = firstValue + secondValue;
        int sum = secondValue;

        while (current <= 8)
        {
            firstValue = secondValue;
            secondValue = current;
            current = firstValue + secondValue;
            if (current % 2 == 0) sum += current;
        }

        return sum;
    }
    */

    /*
    public static int FibonacciProblem34()
    {
        int firstValue = 1;
        int secondValue = 2;
        int current = firstValue + secondValue;
        int sum = secondValue;

        while (current <= 34)
        {
            firstValue = secondValue;
            secondValue = current;
            current = firstValue + secondValue;
            if (current % 2 == 0) sum += current;
        }

        return sum;
    }
    */

    public static int FibonacciProblem()
    {
        int firstValue = 1;
        int secondValue = 2;
        int current = firstValue + secondValue;
        int sum = secondValue;

        while (current <= 4000000)
        {
            firstValue = secondValue;
            secondValue = current;
            current = firstValue + secondValue;
            if (current % 2 == 0) sum += current;
        }

        return sum;
    }
}