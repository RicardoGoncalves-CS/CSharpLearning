using System.Diagnostics;

namespace Model;

public class BubbleSorter : Sorter
{
    Stopwatch stopWatch =Stopwatch.StartNew();



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

        int length = input.Length;
        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                if (input[i] > input[j])
                {
                    int sort = input[i];
                    input[i] = input[j];
                    input[j] = sort;
                }
            }
        }

        stopWatch.Stop();


        return input;
    }
}