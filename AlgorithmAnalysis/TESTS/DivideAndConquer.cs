using System;
using Xunit;

namespace AlgorithmAnalysis.Tests
{
    public class DivideAndConquerTests
    {
        [Theory]
        [InlineData(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]  // [4, -1, 2, 1] -> Toplam: 6
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 15)]  // Tüm dizi en büyük alt dizi
        [InlineData(new int[] { -1, -2, -3, -4 }, -1)] // Tek bir eleman en büyük alt dizi
        [InlineData(new int[] { 3, -1, 4, -1, 2, -4, 3, -2, 3 }, 7)] // [3, -1, 4, -1, 2] -> Toplam: 7
        [InlineData(new int[] { 2, -1, 2, 3, 4, -5, 2, 1 }, 10)]  // [2, -1, 2, 3, 4] -> Toplam: 10
        public void FindMaxSubArray_ShouldReturnCorrectResult(int[] arr, int expected)
        {
            int operationCount = 0;
            int result = DivideAndConquer.FindMaxSubArray(arr, ref operationCount);
            Assert.Equal(expected, result);
        }
    }
}
