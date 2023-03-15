using Model;
using System.Diagnostics;

namespace SortManager.Model
{
    public class InsertionSort : Sorter
    {
        private Stopwatch stopWatch = Stopwatch.StartNew();


        public override long GetMilliseconds()
        {
            return stopWatch.ElapsedMilliseconds;
        }
        public override long GetTicks()
        {
            return stopWatch.ElapsedTicks;
        }
        public override int[] Sort(int[] input)
        {
            stopWatch.Start();

            for (int i = 1; i < input.Length; ++i)
            {
                int current = input[i];
                int j = i - 1;

                while (j >= 0 && input[j] > current)
                {
                    input[j + 1] = input[j];
                    j--;
                }
                input[j + 1] = current;
            }

            stopWatch.Stop();


            return input;
        }
    }
}
