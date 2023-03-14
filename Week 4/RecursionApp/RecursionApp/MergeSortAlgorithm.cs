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
        int inputArrayCounter = 0;
        // rightArray counter
        int rightArrayCounter = 0;


        for (; inputArrayCounter < length; inputArrayCounter++)
        {
            // if i counter is less than middle, copies the value to leftArray
            if(inputArrayCounter < middle)
            {
                leftArray[inputArrayCounter] = inputArray[inputArrayCounter];
            }
            // if i counter is greater than or equal to middle, copies the value to rightArray and increments j
            else
            {
                rightArray[rightArrayCounter] = inputArray[inputArrayCounter];
                rightArrayCounter++;
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

        int originalIndex = 0, leftIndex = 0, rightIndex = 0;

        while(leftIndex < leftSize && rightIndex < rightSize)
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

        while(leftIndex < leftSize)
        {
            inputArray[originalIndex] = leftArray[leftIndex];
            originalIndex++;
            leftIndex++;
        }

        while(rightIndex < rightSize)
        {
            inputArray[originalIndex] = rightArray[rightIndex];
            originalIndex++;
            rightIndex++;
        }
    }
}
