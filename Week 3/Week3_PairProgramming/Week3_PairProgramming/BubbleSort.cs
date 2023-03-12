namespace Week3_PairProgramming
{
    public class BubbleArraySort
    {

        public static int[] Sort(int[] bubbleArray)
        {
            int length = bubbleArray.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (bubbleArray[i] > bubbleArray[j])
                    {
                        int sort = bubbleArray[i];
                        bubbleArray[i] = bubbleArray[j];
                        bubbleArray[j] = sort;
                    }
                }
            }
            return bubbleArray;
        }
    }
}
