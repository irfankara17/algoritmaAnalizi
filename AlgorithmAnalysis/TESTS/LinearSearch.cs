using System;
using Xunit;
using AlgorithmAnalysis.SearchAlgorithms;

public class LinearSearchTests
{
    [Fact]
    public void Search_EmptyArray_ReturnsMinusOne()
    {
        int[] array = new int[] { };
        int target = 5;
        int operationCount = 0;

        int result = LinearSearch.Search(array, target, ref operationCount);

        Assert.Equal(-1, result);
    }

    [Fact]
    public void Search_SingleElementArray_TargetFound()
    {
        int[] array = new int[] { 10 };
        int target = 10;
        int operationCount = 0;

        int result = LinearSearch.Search(array, target, ref operationCount);

        Assert.Equal(0, result);
    }

    [Fact]
    public void Search_SingleElementArray_TargetNotFound()
    {
        int[] array = new int[] { 10 };
        int target = 5;
        int operationCount = 0;

        int result = LinearSearch.Search(array, target, ref operationCount);

        Assert.Equal(-1, result);
    }

    [Fact]
    public void Search_MultipleElements_TargetAtBeginning()
    {
        int[] array = new int[] { 5, 3, 8, 2, 7 };
        int target = 5;
        int operationCount = 0;

        int result = LinearSearch.Search(array, target, ref operationCount);

        Assert.Equal(0, result);
    }

    [Fact]
    public void Search_MultipleElements_TargetAtMiddle()
    {
        int[] array = new int[] { 5, 3, 8, 2, 7 };
        int target = 8;
        int operationCount = 0;

        int result = LinearSearch.Search(array, target, ref operationCount);

        Assert.Equal(2, result);
    }

    [Fact]
    public void Search_MultipleElements_TargetAtEnd()
    {
        int[] array = new int[] { 5, 3, 8, 2, 7 };
        int target = 7;
        int operationCount = 0;

        int result = LinearSearch.Search(array, target, ref operationCount);

        Assert.Equal(4, result);
    }

    [Fact]
    public void Search_MultipleElements_TargetNotFound()
    {
        int[] array = new int[] { 5, 3, 8, 2, 7 };
        int target = 1;
        int operationCount = 0;

        int result = LinearSearch.Search(array, target, ref operationCount);

        Assert.Equal(-1, result);
    }
}