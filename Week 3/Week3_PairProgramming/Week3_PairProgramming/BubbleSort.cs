namespace Week3_PairProgramming
{
    public class BubbleSort
    {

        public static int[] Sort(int[] bubbleArray)
        {
            for (int i = 0; i < bubbleArray.Length; i++)
            {
                for (int j = i + 1; j < bubbleArray.Length; j++)
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