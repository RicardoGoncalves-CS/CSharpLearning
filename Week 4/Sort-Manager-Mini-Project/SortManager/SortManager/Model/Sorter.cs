namespace Model;

public abstract class Sorter
{

    public abstract int[] Sort(int[] input);
    public abstract long GetMilliseconds();
    public abstract long GetTicks();
    public Sorter() { }
}