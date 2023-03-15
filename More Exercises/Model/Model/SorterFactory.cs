namespace Model;

public static class SorterFactory
{
    public static Sorter CreateSorter(string type)
    {
        switch (type.ToLower())
        {
            case "bubblesort":
                return new BubbleSorter();
            case "mergesort":
                return new MergeSorter();
            default:
                throw new ArgumentException("Invalid employee type");
        }
    }
}