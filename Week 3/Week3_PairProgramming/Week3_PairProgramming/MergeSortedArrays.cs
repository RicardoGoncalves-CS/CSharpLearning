namespace Week3_PairProgramming
{
    public class MergeSortedArrays
    {
        public static int[] Merge(int[] firstArr, int[] secondArr)
        {
            if (firstArr == null || secondArr == null) throw new NullReferenceException();
            if (firstArr.Length == 0) return secondArr;
            if (secondArr.Length == 0) return firstArr;

            int[] mergedArr = new int[firstArr.Length + secondArr.Length];

            int i = 0; int j = 0; int k = 0;

            while (i < firstArr.Length && j < secondArr.Length)
            {
                if (firstArr[i] < secondArr[j])
                    mergedArr[k++] = firstArr[i++];
                else
                    mergedArr[k++] = secondArr[j++];
            }
            while (i < firstArr.Length)
                mergedArr[k++] = firstArr[i++];

            while (j < secondArr.Length)
                mergedArr[k++] = secondArr[j++];

            return mergedArr;
        }
    }
}
