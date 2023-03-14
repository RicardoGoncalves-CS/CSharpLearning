using System;

namespace RecursionApp;

public class MergeSortAlgorithmAlin
{
    public static void ArraySplitInHalf(int[] originalArray, out int[] leftArray, out int[] rightArray)
    {
        leftArray = new int[originalArray.Length / 2];
        rightArray = new int[originalArray.Length - originalArray.Length / 2];

        for (int i = 0; i < originalArray.Length; i++)
        {
            if (i < originalArray.Length / 2)
            {
                leftArray[i] = originalArray[i];
            }
            else
            {
                rightArray[i - originalArray.Length / 2] = originalArray[i];
            }
        }
    }

    public static int[] MergeSortedArray(int[] leftArray, int[] rightArray)
    {
        int[] result = new int[leftArray.Length + rightArray.Length];
        int leftIndex = 0, rightIndex = 0;

        for (int resultIndex = 0; resultIndex < result.Length; resultIndex++)
        {
            if (rightIndex == rightArray.Length)
            {
                result[resultIndex] = leftArray[leftIndex];
                leftIndex++;
                continue;
            }
            if (leftIndex == leftArray.Length)
            {

                result[resultIndex] = rightArray[rightIndex];
                rightIndex++;
                continue;
            }
            if (leftArray[leftIndex] < rightArray[rightIndex])
            {
                result[resultIndex] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                result[resultIndex] = rightArray[rightIndex];
                rightIndex++;
            }
        }
        return result;
    }

    public static int[] RecursiveMergeSorter(int[] array)
    {
        if (array == null)
            throw new ArgumentNullException();

        if (array.Length <= 1) return array;

        int[] result = new int[array.Length], leftArray, rightArray; ;

        ArraySplitInHalf(array, out leftArray, out rightArray);

        leftArray = RecursiveMergeSorter(leftArray);
        rightArray = RecursiveMergeSorter(rightArray);
        result = MergeSortedArray(leftArray, rightArray);

        return result;
    }
}
