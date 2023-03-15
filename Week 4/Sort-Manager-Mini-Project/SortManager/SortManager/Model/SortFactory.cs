using SortManager.Model;

namespace Model;

public static class SorterFactory
{
    public static Sorter CreateSorter(string type)
    {
        switch (type)
        {
            case "a":
                return new BubbleSorter();
            case "b":
                return new MergeSorter();
            case "c":
                return new InsertionSort();
            case "d":
                return new DotNetSort();
            default:
                throw new ArgumentException("Invalid sort type");
        }
    }
}