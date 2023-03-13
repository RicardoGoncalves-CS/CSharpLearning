namespace RecursionApp;

public class Program
{
    static void Main()
    {
        Console.WriteLine(SumLoop(100));
        Console.WriteLine(RecursiveSum(100));

        // Iterative Sum of numbers approach
        // O(n)
        int SumLoop(int toNumber)
        {
            int sum = 0;

            for (int i = 1; i <= toNumber; i++)
            {
                sum += i;
            }

            return sum;
        }

        // Recursive Sum of numbers approach
        // O(n)
        int RecursiveSum(int toNumber)
        {
            if (toNumber == 0) return 0;

            int prev = RecursiveSum(toNumber - 1);
            int sum = toNumber + prev;

            return sum;
        }

        // RecursiveMergeSort
        int[] arr = { 4, 56, 1, 7, 23, 65, 11 };

        RecursiveBinaryMergeSort.MergeSort(arr);

        foreach(int number in arr)
        {
            Console.WriteLine(number);
        }
    }
}