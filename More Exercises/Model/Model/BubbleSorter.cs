using System.Diagnostics;

namespace Model;

public class BubbleSorter : Sorter
{
    Stopwatch stopWatch = new System.Diagnostics.Stopwatch();

    private long _timelapse;
    public override long Timelapse
    {
        get;
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

        _timelapse = stopWatch.ElapsedMilliseconds;

        return input;
    }
}