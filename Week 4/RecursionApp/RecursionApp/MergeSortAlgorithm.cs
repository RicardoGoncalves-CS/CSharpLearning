namespace RecursionApp;

/*  MergeSort Algorithm
 * 
 *  This algorithm uses the divide-and-conquer approach to sort an array.
 *  
 *  It works by recursively breaking down the input array into smaller subarrays, sorting each
 *  separately and then merging them back together into a single sorted array.
 */
public static class MergeSortAlgorithm
{
    public static void MergeSort(int[] inputArray)
    {
        int length = inputArray.Length;
        int middle;

        if (length <= 1) return;

        // find the middle point inputArray
        middle = length / 2;

        // create leftArray with size of middle
        int[] leftArray = new int[middle];
        // create rightArray with size of inputArray minus middle value
        int[] rightArray = new int[length - middle];

        // inputArray counter
        int i = 0;
        // rightArray counter
        int j = 0;


        for (; i < length; i++)
        {
            // if i counter is less than middle, copies the value to leftArray
            if(i < middle)
            {
                leftArray[i] = inputArray[i];
            }
            // if i counter is greater than or equal to middle, copies the value to rightArray and increments j
            else
            {
                rightArray[j] = inputArray[i];
                j++;
            }
        }

        // Recursively calls MergeSort from left to right
        MergeSort(leftArray);
        MergeSort(rightArray);

        // If both left and right are sorted calls Merge method
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
