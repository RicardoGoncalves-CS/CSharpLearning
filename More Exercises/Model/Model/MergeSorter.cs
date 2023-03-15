using System.Diagnostics;

namespace Model;

internal class MergeSorter : Sorter
{
    private Stopwatch stopWatch = new Stopwatch();

    private long _timelapse;
    public override long Timelapse
    {
        get;
    }

    public override int[] Sort(int[] input)
    {
        stopWatch.Start();

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

        stopWatch.Stop();
        _timelapse = stopWatch.ElapsedMilliseconds;
        return input;
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