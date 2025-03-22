using System;
using Xunit;

namespace AlgorithmAnalysis.Tests
{
    public class KthSmallestFinderTests
    {
        [Theory]
        [InlineData(new int[] { 7, 10, 4, 3, 20, 15 }, 3, 7)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 2, 2)]
        [InlineData(new int[] { 5, 3, 8, 6, 2, 7, 4, 1 }, 5, 5)]
        [InlineData(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 1, 1)]
        [InlineData(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 10, 10)]
        public void FindKthSmallest_Sort_ShouldReturnCorrectResult(int[] arr, int k, int expected)
        {
            int operationCount = 0;
            int result = KthSmallestFinder.FindKthSmallest_Sort(arr, k, ref operationCount);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 7, 10, 4, 3, 20, 15 }, 3, 7)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 2, 2)]
        [InlineData(new int[] { 5, 3, 8, 6, 2, 7, 4, 1 }, 5, 5)]
        [InlineData(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 1, 1)]
        [InlineData(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 10, 10)]
        public void FindKthSmallest_Insertion_ShouldReturnCorrectResult(int[] arr, int k, int expected)
        {
            int operationCount = 0;
            int result = KthSmallestFinder.FindKthSmallest_Insertion(arr, k, ref operationCount);
            Assert.Equal(expected, result);
        }
    }
}

