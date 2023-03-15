using System.Diagnostics;

namespace Model;

public class DotNetSort : Sorter
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

        Array.Sort(input);

        stopWatch.Stop();
        return input;
    }
}