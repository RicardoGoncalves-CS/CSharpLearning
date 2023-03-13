namespace RecursionApp;

public static class MergeSortAlgorithm2
{
    public static void MergeSortAlgorithm(int[] inputArray, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            MergeSortAlgorithm(inputArray, left, middle);
            MergeSortAlgorithm(inputArray, middle + 1, right);
            Merge(inputArray, left, middle, right);
        }
    }


    public static void Merge(int[] inputArray, int left, int middle, int right)
    {
        int leftSize = middle - left + 1;
        int rightSize = right - middle;
        int[] leftArray = new int[leftSize];
        int[] rightArray = new int[rightSize];

        for (int i = 0; i < leftSize; i++)
        {
            leftArray[i] = inputArray[left + i];
        }
        for (int j = 0; j < rightSize; j++)
        {
            rightArray[j] = inputArray[middle + 1 + j];
        }

        int k = left;
        int l = 0;
        int r = 0;

        while (l < leftSize && r < rightSize)
        {
            if (leftArray[l] <= rightArray[r])
            {
                inputArray[k] = leftArray[l];
                l++;
            }
            else
            {
                inputArray[k] = rightArray[r];
                r++;
            }
            k++;
        }

        while (l < leftSize)
        {
            inputArray[k] = leftArray[l];
            l++;
            k++;
        }

        while (r < rightSize)
        {
            inputArray[k] = rightArray[r];
            r++;
            k++;
        }
    }
}
