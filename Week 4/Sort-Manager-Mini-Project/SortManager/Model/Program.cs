using System.Diagnostics;

namespace Model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Examples

            Random rand = new Random();
            int[] arr = new int[50];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next();
            }

            BubbleSorter bSort = new BubbleSorter();
            int[] sorted = bSort.Sort(arr);
            long elapsedBubbleSorter = bSort.Timelapse;

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Elapsed time: {elapsedBubbleSorter} ms");
            Console.WriteLine();

            MergeSorter mSort = new MergeSorter();
            int[] sorted2 = mSort.Sort(arr);
            long elapsedMergeSorter = mSort.Timelapse;

            foreach (var item in sorted2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Elapsed time: {elapsedMergeSorter} ms");
            Console.WriteLine();

            Sorter myBubbleSorter = SorterFactory.CreateSorter("mergesort");
            int[] sorted3 = myBubbleSorter.Sort(arr);
            long elapsedFactorySorter = myBubbleSorter.Timelapse;

            foreach (var item in sorted3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Elapsed time: {elapsedFactorySorter} ms");
            Console.WriteLine();
        }
    }
}