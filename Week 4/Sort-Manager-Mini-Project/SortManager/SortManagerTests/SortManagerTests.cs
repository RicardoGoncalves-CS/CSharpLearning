using Microsoft.VisualStudio.TestPlatform.TestHost;
using Model;
using SortManager.Model;
using System.Globalization;

namespace SortManagerTests
{
    public class Tests
    {
        [TestCase("a")]
        public void CreateSorter_ReturnsABubbleSorter(string type)
        {
            Sorter sorter = SorterFactory.CreateSorter(type);
            Assert.IsInstanceOf<BubbleSorter>(sorter);
        }

        [TestCase("b")]
        public void CreateSorter_ReturnsAMergeSorter(string type)
        {
            Sorter sorter = SorterFactory.CreateSorter(type);
            Assert.IsInstanceOf<MergeSorter>(sorter);
        }

        [TestCase("c")]
        public void CreateSorter_ReturnsAInsertionSorter(string type)
        {
            Sorter sorter = SorterFactory.CreateSorter(type);
            Assert.IsInstanceOf<InsertionSort>(sorter);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(250, 250)]
        [TestCase(1000, 1000)]
        [TestCase(2000, 2000)]
        public void ArrayBuilder_ReturnsArrayOfDesiredSize(int desired, int expected)
        {
            int[] arr = ArrayBuilder.GenArray(desired);
            Assert.That(arr.Length, Is.EqualTo(expected));
        }

        [Test]
        public void WhenGivenANegativeValue_ArrayBuild_ThrowException()
        {
            int size = -5;
            Assert.That(() => ArrayBuilder.GenArray(size), Throws.TypeOf<OverflowException>());
        }

        [TestCase(new int[] { 2, 5, 6, 0, 4 }, new int[] { 0, 2, 4, 5, 6 })]
        [TestCase(new int[] { -10, 10, 11, 2 }, new int[] { -10, 2, 10, 11 })]
        [TestCase(new int[] { 10, 9, 8, 7, 4 }, new int[] { 4, 7, 8, 9, 10 })]
        public void WhenGivenAnUnsortedArray_BubbleSorter_ReturnsSortedArray(int[] input, int[] expected)
        {
            BubbleSorter sorter = new BubbleSorter();
            Assert.That(sorter.Sort(input), Is.EqualTo(expected));
        }

        [TestCase(new int[] { 2, 5, 6, 0, 4 }, new int[] { 0, 2, 4, 5, 6 })]
        [TestCase(new int[] { -10, 10, 11, 2 }, new int[] { -10, 2, 10, 11 })]
        [TestCase(new int[] { 10, 9, 8, 7, 4 }, new int[] { 4, 7, 8, 9, 10 })]
        public void WhenGivenAnUnsortedArray_MergeSorter_ReturnsSortedArray(int[] input, int[] expected)
        {
            MergeSorter sorter = new MergeSorter();
            Assert.That(sorter.Sort(input), Is.EqualTo(expected));
        }

        [TestCase(new int[] { 2, 5, 6, 0, 4 }, new int[] { 0, 2, 4, 5, 6 })]
        [TestCase(new int[] { -10, 10, 11, 2 }, new int[] { -10, 2, 10, 11 })]
        [TestCase(new int[] { 10, 9, 8, 7, 4 }, new int[] { 4, 7, 8, 9, 10 })]
        public void WhenGivenAnUnsortedArray_InsertionSort_ReturnsSortedArray(int[] input, int[] expected)
        {
            InsertionSort sorter = new InsertionSort();
            Assert.That(sorter.Sort(input), Is.EqualTo(expected));
        }


    }
}