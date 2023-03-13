using RecursionApp;

namespace Tests;

public class Tests
{
    [TestCase(new int[] { 4, 56, 1, 7, 23, 65, 11 }, new int[] { 1, 4, 7, 11, 23, 56, 65 })]
    [TestCase(new int[] { 7, 3, -1, 77 }, new int[] { -1, 3, 7, 77 })]
    [TestCase(new int[] { -10, -20, -21, 30 }, new int[] { -21, -20, -10, 30 })]
    public void GivenAnUnsortedArray_MergeSort_SortsTheArray(int[] arr, int[] expected)
    {
        MergeSortAlgorithm.MergeSort(arr);
        Assert.That(arr, Is.EqualTo(expected));
    }

    [TestCase(new int[] { }, new int[] { })]
    public void GivenAnEmptyArrayAsInputTo_MergeSort_ArrayRemainsEmpty(int[] arr, int[] expected)
    {
        MergeSortAlgorithm.MergeSort(arr);
        Assert.That(arr, Is.EqualTo(expected));
    }
}