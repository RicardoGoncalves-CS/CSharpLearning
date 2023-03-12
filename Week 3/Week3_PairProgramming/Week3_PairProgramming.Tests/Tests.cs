namespace Week3_PairProgramming.Tests
{
    public class Tests
    {
        [TestCase(new int[] { 5, 7, 2, 9, 3, 4 }, new int[] { 2, 3, 4, 5, 7, 9 })]
        [TestCase(new int[] { 10, 5, 100, 21, 98 }, new int[] { 5, 10, 21, 98, 100 })]
        [TestCase(new int[] { 8, 8, 2, 17, 0, -5 }, new int[] { -5, 0, 2, 8, 8, 17 })]
        public void GivenUnsortedArray_Sort_ReturnSortedArray(int[] source, int[] expected)
        {
            // Act
            BubbleArraySort.Sort(source);

            // Assert
            Assert.That(source, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 5, 10, 21, 98, 100 }, new int[] { 2, 3, 4, 5, 7, 9 }, new int[] { 2, 3, 4, 5, 5, 7, 9, 10, 21, 98, 100 })]
        [TestCase(new int[] { 1, 3, 5, 14 }, new int[] { 7, 8, 9 }, new int[] { 1, 3, 5, 7, 8, 9, 14 })]
        [TestCase(new int[] { -5, 0, 2, 8, 8, 17 }, new int[] { -1000, 10, 100 }, new int[] { -1000, -5, 0, 2, 8, 8, 10, 17, 100 })]
        public void GivenTwoSortedArrays_Merge_ReturnMergedSortedArray(int[] firstArr, int[] secondArr, int[] expected)
        {
            // Act
            int[] result = MergeSortedArrays.Merge(firstArr, secondArr);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(new int[] { }, new int[] { -1000, 10, 100 }, new int[] { -1000, 10, 100 })]
        [TestCase(new int[] { -1000, 10, 100 }, new int[] { }, new int[] { -1000, 10, 100 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        public void GivenEmptyArrays_Merge_ReturnExpectedArray(int[] firstArr, int[] secondArr, int[] expected)
        {
            // Act
            int[] result = MergeSortedArrays.Merge(firstArr, secondArr);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(null, new int[] { 2, 3, 4, 5, 7, 9 })]
        public void GivenNullArray_Merge_ThrowsException(int[] firstArr, int[] secondArr)
        {
            // Assert
            Assert.That(() => MergeSortedArrays.Merge(firstArr, secondArr), Throws.TypeOf<NullReferenceException>());
        }
    }
}