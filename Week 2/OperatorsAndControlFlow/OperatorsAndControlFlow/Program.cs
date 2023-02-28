namespace OperatorsAndControlFlow;

public class Program
{
    static void Main()
    {
        int x = 5;
        int y = 5;

        int a = x++; // post increment operator -> x is assigned before increment
        int b = ++y; // pre increment operator -> y is incremented befor assignment

        // Demo
        Console.WriteLine("x = " + x + ", y = " + y);
        Console.WriteLine("a = " + a + ", b = " + b);

        // var is a placeholder for the data type. The compiler evaluates the data types in the operation to infer the var type.
        var c = 10 / 3;
        var d = 9.5 / 4;

        Console.WriteLine("c is of type " + c.GetType());
        Console.WriteLine("d is of type " + d.GetType());

        // Exercise using GetStones() and GetStonesLeft()
        int stones = GetStones(156); // expect stones to be 11
        int poundsLeft = GetPoundsLeft(156); // expect stones to be 2

        Console.WriteLine(stones);
        Console.WriteLine(poundsLeft);
    }

    public static int GetStones(int totalPounds)
    {
        return totalPounds / 14;
    }

    public static int GetPoundsLeft(int totalPounds)
    {
        return totalPounds % 14;
    }
}