using System;
using Xunit;
using AlgorithmAnalysis.Algorithms.SearchAlgorithms;

public class MinMaxFinderTests
{
    [Fact]
    public void Min_EmptyArray_ThrowsException()
    {
        int[] array = new int[] { };
        int operationCount = 0;

        Assert.Throws<IndexOutOfRangeException>(() => MinMaxFinder.Min(array, ref operationCount));
    }

    [Fact]
    public void Max_EmptyArray_ThrowsException()
    {
        int[] array = new int[] { };
        int operationCount = 0;

        Assert.Throws<IndexOutOfRangeException>(() => MinMaxFinder.Max(array, ref operationCount));
    }

    [Fact]
    public void Min_SingleElementArray_ReturnsSameElement()
    {
        int[] array = new int[] { 42 };
        int operationCount = 0;

        int result = MinMaxFinder.Min(array, ref operationCount);

        Assert.Equal(42, result);
    }

    [Fact]
    public void Max_SingleElementArray_ReturnsSameElement()
    {
        int[] array = new int[] { 42 };
        int operationCount = 0;

        int result = MinMaxFinder.Max(array, ref operationCount);

        Assert.Equal(42, result);
    }

    [Fact]
    public void Min_MultipleElements_ReturnsMinimumValue()
    {
        int[] array = new int[] { 3, 1, 4, 1, 5, 9, 2, 6 };
        int operationCount = 0;

        int result = MinMaxFinder.Min(array, ref operationCount);

        Assert.Equal(1, result);
    }

    [Fact]
    public void Max_MultipleElements_ReturnsMaximumValue()
    {
        int[] array = new int[] { 3, 1, 4, 1, 5, 9, 2, 6 };
        int operationCount = 0;

        int result = MinMaxFinder.Max(array, ref operationCount);

        Assert.Equal(9, result);
    }
}