namespace UnitTestApp;

public class Program
{
    static void Main()
    {
        /*
        int inputValue = Int32.Parse(Console.ReadLine());
        string output = MyMethod(inputValue);
        Console.WriteLine(output);
        */

        int result = SumEvenFive(9);
        Console.WriteLine(result);
    }

    public static int SumEvenFive(int max)
    {
        int current = 1;
        int sum = 0;

        while (current < max)
        {
            if ((current % 2 == 0) || (current % 5 == 0))
            {
                sum += current;
            }
            current++;
        }
        return sum;
    }

    
}