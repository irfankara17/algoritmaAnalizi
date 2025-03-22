using System;
using Xunit;

namespace AlgorithmAnalysis.Tests
{
    public class BinarySearchTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 5, 7, 9, 11, 13 }, 5, 2)]  // 5 elemanı index 2'de
        [InlineData(new int[] { 2, 4, 6, 8, 10, 12 }, 8, 3)]  // 8 elemanı index 3'te
        [InlineData(new int[] { -10, -5, 0, 5, 10, 15 }, -10, 0)]  // -10 ilk indexte
        [InlineData(new int[] { -10, -5, 0, 5, 10, 15 }, 15, 5)]  // 15 son indexte
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 11, -1)]  // 11 bulunamaz (-1)
        [InlineData(new int[] { 42 }, 42, 0)]  // Tek elemanlı dizi, bulunan eleman index 0
        [InlineData(new int[] { 42 }, 10, -1)]  // Tek elemanlı dizi, bulunamayan eleman
        [InlineData(new int[] { }, 5, -1)]  // Boş dizi, her zaman -1 döndürmeli
        public void Search_ShouldReturnCorrectIndex(int[] arr, int target, int expectedIndex)
        {
            int operationCount = 0;
            int result = BinarySearch.Search(arr, target, ref operationCount);
            Assert.Equal(expectedIndex, result);
        }
    }
}
