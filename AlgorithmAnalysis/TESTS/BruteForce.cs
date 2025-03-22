using System;
using Xunit;
using AlgorithmAnalysis.Algorithms.MaxSubArrayAlgorithms;

namespace AlgorithmAnalysis.Tests
{
    public class BruteForceTests
    {
        [Fact]
        public void FirstBruteForce_ShouldReturnMaxSum_ForPositiveNumbers()
        {
            int operationCount = 0;
            int[] arr = { 1, 2, 3, 4, 5 };
            int result = BruteForce.FirstBruteForce(arr, ref operationCount);

            Assert.Equal(15, result);
        }

        [Fact]
        public void FirstBruteForce_ShouldReturnMaxSum_ForMixedNumbers()
        {
            int operationCount = 0;
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int result = BruteForce.FirstBruteForce(arr, ref operationCount);

            Assert.Equal(6, result); // [4, -1, 2, 1] alt dizisi
        }

        [Fact]
        public void FirstBruteForce_ShouldReturnMaxSum_ForAllNegativeNumbers()
        {
            int operationCount = 0;
            int[] arr = { -1, -2, -3, -4 };
            int result = BruteForce.FirstBruteForce(arr, ref operationCount);

            Assert.Equal(-1, result); // Tek bir eleman seçmek en iyisi
        }

        [Fact]
        public void FirstBruteForce_ShouldHandleSingleElement()
        {
            int operationCount = 0;
            int[] arr = { 5 };
            int result = BruteForce.FirstBruteForce(arr, ref operationCount);

            Assert.Equal(5, result);
        }

        [Fact]
        public void SecondBruteForce_ShouldReturnMaxSum_ForPositiveNumbers()
        {
            int operationCount = 0;
            int[] arr = { 1, 2, 3, 4, 5 };
            int result = BruteForce.SecondBruteForce(arr, ref operationCount);

            Assert.Equal(15, result);
        }

        [Fact]
        public void SecondBruteForce_ShouldReturnMaxSum_ForMixedNumbers()
        {
            int operationCount = 0;
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int result = BruteForce.SecondBruteForce(arr, ref operationCount);

            Assert.Equal(6, result);
        }

        [Fact]
        public void SecondBruteForce_ShouldReturnMaxSum_ForAllNegativeNumbers()
        {
            int operationCount = 0;
            int[] arr = { -1, -2, -3, -4 };
            int result = BruteForce.SecondBruteForce(arr, ref operationCount);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void SecondBruteForce_ShouldHandleSingleElement()
        {
            int operationCount = 0;
            int[] arr = { 5 };
            int result = BruteForce.SecondBruteForce(arr, ref operationCount);

            Assert.Equal(5, result);
        }
    }
}
