using System.Diagnostics;

namespace Model;

public class MergeSorter : Sorter
{
    private Stopwatch stopWatch = Stopwatch.StartNew();


    private int[] MergeSort(int[] input)
    {


        int length = input.Length;
        int middle;

        if (length <= 1) return input;

        middle = length / 2;

        int[] leftArray = new int[middle];
        int[] rightArray = new int[length - middle];

        int inputArrayCounter = 0;
        int rightArrayCounter = 0;


        for (; inputArrayCounter < length; inputArrayCounter++)
        {
            if (inputArrayCounter < middle)
            {
                leftArray[inputArrayCounter] = input[inputArrayCounter];
            }
            else
            {
                rightArray[rightArrayCounter] = input[inputArrayCounter];
                rightArrayCounter++;
            }
        }

        Sort(leftArray);
        Sort(rightArray);

        Merge(leftArray, rightArray, input);

        return input;
    }
    public override int[] Sort(int[] input)
    {
        stopWatch.Restart();
        int[] result = MergeSort(input);
        stopWatch.Stop();
        return result;
    }
    public  override long GetMilliseconds()
    {
        return stopWatch.ElapsedMilliseconds;
    }
    public override long GetTicks()
    {
        return stopWatch.ElapsedTicks;
    }
    private static void Merge(int[] leftArray, int[] rightArray, int[] inputArray)
    {
        int leftSize = inputArray.Length / 2;
        int rightSize = inputArray.Length - leftSize;

        int originalIndex = 0, leftIndex = 0, rightIndex = 0;

        while (leftIndex < leftSize && rightIndex < rightSize)
        {
            if (leftArray[leftIndex] < rightArray[rightIndex])
            {
                inputArray[originalIndex] = leftArray[leftIndex];
                originalIndex++;
                leftIndex++;
            }
            else
            {
                inputArray[originalIndex] = rightArray[rightIndex];
                originalIndex++;
                rightIndex++;
            }
        }

        while (leftIndex < leftSize)
        {
            inputArray[originalIndex] = leftArray[leftIndex];
            originalIndex++;
            leftIndex++;
        }

        while (rightIndex < rightSize)
        {
            inputArray[originalIndex] = rightArray[rightIndex];
            originalIndex++;
            rightIndex++;
        }
    }
}