using System;
using Xunit;
using AlgorithmAnalysis.Algorithms.MaxSubArrayAlgorithms;

namespace AlgorithmAnalysis.Tests
{
    public class KadaneTests
    {
        [Fact]
        public void FindMaxSubArray_ShouldReturnMaxSum_ForPositiveNumbers()
        {
            int operationCount = 0;
            int[] arr = { 1, 2, 3, 4, 5 };
            int result = Kadane.FindMaxSubArray(arr, ref operationCount);

            Assert.Equal(15, result);
        }

        [Fact]
        public void FindMaxSubArray_ShouldReturnMaxSum_ForMixedNumbers()
        {
            int operationCount = 0;
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int result = Kadane.FindMaxSubArray(arr, ref operationCount);

            Assert.Equal(6, result); // [4, -1, 2, 1] alt dizisinin toplamı
        }

        [Fact]
        public void FindMaxSubArray_ShouldReturnMaxSum_ForAllNegativeNumbers()
        {
            int operationCount = 0;
            int[] arr = { -1, -2, -3, -4 };
            int result = Kadane.FindMaxSubArray(arr, ref operationCount);

            Assert.Equal(-1, result); // Tek bir eleman seçmek en iyisi
        }

        [Fact]
        public void FindMaxSubArray_ShouldReturnZero_ForEmptyArray()
        {
            int operationCount = 0;
            int[] arr = { };
            int result = Kadane.FindMaxSubArray(arr, ref operationCount);

            Assert.Equal(int.MinValue, result); // Çünkü başlangıçta maxSum int.MinValue
        }

        [Fact]
        public void FindMaxSubArray_ShouldHandleSingleElement()
        {
            int operationCount = 0;
            int[] arr = { 5 };
            int result = Kadane.FindMaxSubArray(arr, ref operationCount);

            Assert.Equal(5, result);
        }
    }
}
using System;
using Xunit;
using AlgorithmAnalysis.Algorithms.MaxSubArrayAlgorithms;

namespace AlgorithmAnalysis.Tests
{
    public class KadaneTests
    {
        [Fact]
        public void FindMaxSubArray_ShouldReturnMaxSum_ForPositiveNumbers()
        {
            int operationCount = 0;
            int[] arr = { 1, 2, 3, 4, 5 };
            int result = Kadane.FindMaxSubArray(arr, ref operationCount);

            Assert.Equal(15, result);
        }

        [Fact]
        public void FindMaxSubArray_ShouldReturnMaxSum_ForMixedNumbers()
        {
            int operationCount = 0;
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int result = Kadane.FindMaxSubArray(arr, ref operationCount);

            Assert.Equal(6, result); // [4, -1, 2, 1] alt dizisinin toplamı
        }

        [Fact]
        public void FindMaxSubArray_ShouldReturnMaxSum_ForAllNegativeNumbers()
        {
            int operationCount = 0;
            int[] arr = { -1, -2, -3, -4 };
            int result = Kadane.FindMaxSubArray(arr, ref operationCount);

            Assert.Equal(-1, result); // Tek bir eleman seçmek en iyisi
        }

        [Fact]
        public void FindMaxSubArray_ShouldReturnZero_ForEmptyArray()
        {
            int operationCount = 0;
            int[] arr = { };
            int result = Kadane.FindMaxSubArray(arr, ref operationCount);

            Assert.Equal(int.MinValue, result); // Çünkü başlangıçta maxSum int.MinValue
        }

        [Fact]
        public void FindMaxSubArray_ShouldHandleSingleElement()
        {
            int operationCount = 0;
            int[] arr = { 5 };
            int result = Kadane.FindMaxSubArray(arr, ref operationCount);

            Assert.Equal(5, result);
        }
    }
}
