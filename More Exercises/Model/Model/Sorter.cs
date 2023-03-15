namespace Model;

public abstract class Sorter
{
    public abstract long Timelapse { get; }

    public abstract int[] Sort(int[] input);
    public Sorter() { }
}