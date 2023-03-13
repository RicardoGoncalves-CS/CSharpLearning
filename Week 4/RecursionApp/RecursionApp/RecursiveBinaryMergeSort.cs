namespace RecursionApp;

/*  MergeSort Algorithm
 * 
 *  This algorithm uses the divide-and-conquer approach to sort an array.
 *  
 *  It works by recursively breaking down the input array into smaller subarrays, sorting each
 *  separately and then merging them back together into a single sorted array.
 */
public static class RecursiveBinaryMergeSort
{
    public static void MergeSort(int[] inputArray)
    {
        int length = inputArray.Length;
        int middle;

        if (length <= 1) return;

        middle = length / 2;

        int[] leftArray = new int[middle];
        int[] rightArray = new int[length - middle];

        int i = 0;
        int j = 0;

        for (; i < length; i++)
        {
            if(i < middle)
            {
                leftArray[i] = inputArray[i];
            }
            else
            {
                rightArray[j] = inputArray[i];
                j++;
            }
        }

        MergeSort(leftArray);
        MergeSort(rightArray);
        Merge(leftArray, rightArray, inputArray);
    }

    private static void Merge(int[] leftArray, int[] rightArray, int[] inputArray)
    {
        int leftSize = inputArray.Length / 2;
        int rightSize = inputArray.Length - leftSize;

        int i = 0, l = 0, r = 0;

        while(l < leftSize && r < rightSize)
        {
            if (leftArray[l] < rightArray[r])
            {
                inputArray[i] = leftArray[l];
                i++;
                l++;
            }
            else
            {
                inputArray[i] = rightArray[r];
                i++;
                r++;
            }
        }

        while(l < leftSize)
        {
            inputArray[i] = leftArray[l];
            i++;
            l++;
        }

        while(r < rightSize)
        {
            inputArray[i] = rightArray[r];
            i++;
            r++;
        }
    }
}
