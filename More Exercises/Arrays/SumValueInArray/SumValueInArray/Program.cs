namespace SumValueInArray;

public class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 3 };
        Console.WriteLine(SumValuesInArray(array, 0, 6));
    }

    public static int SumValuesInArray(int[] arr, int n1, int n2)
    {
        int total = 0;
        
        for (int i = n1; i < n2; i++)
        {
            total += arr[i];
        }

        return total;
    }
}