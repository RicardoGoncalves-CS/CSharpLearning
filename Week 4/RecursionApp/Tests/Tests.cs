using RecursionApp;
using System;

namespace Tests;

public class RecursiveMergeSortTests
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

    // Alin Tests
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
    [TestCase(new int[] { 1, 5, 9, -2, 5 }, new int[] { -2, 1, 5, 5, 9 })]
    [TestCase(new int[] { 716, 340, 621, 880, 858, 125, 982, 68 }, new int[] { 68, 125, 340, 621, 716, 858, 880, 982 })]

    public void GivenUnsortedArray_MergeSorter_ReturnsSortedArray(int[] arr, int[] expResult)
    {
        int[] sortedArray = MergeSortAlgorithmAlin.RecursiveMergeSorter(arr);
        Assert.That(sortedArray, Is.EqualTo(expResult));

    }
}

