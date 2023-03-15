namespace Model;

public abstract class Sorter
{
    public long _timelapse;

    public abstract long Timelapse { get; }

    public abstract int[] Sort(int[] input);
    public Sorter() { }
}