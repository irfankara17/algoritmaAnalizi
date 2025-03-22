using System;
using Xunit;
using AlgorithmAnalysis.Algorithms.SortAlgorithms;

public class BubleSortTests
{
    [Fact]
    public void Sort_EmptyArray_ReturnsEmptyArray()
    {
        int[] array = new int[] { };
        int operationCount = 0;

        int[] sortedArray = BubleSort.Sort(array, ref operationCount);

        Assert.Empty(sortedArray);
    }

    [Fact]
    public void Sort_SortedArray_ReturnsSameArray()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5 };
        int operationCount = 0;

        int[] sortedArray = BubleSort.Sort(array, ref operationCount);

        Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, sortedArray);
    }

    [Fact]
    public void Sort_ReversedArray_ReturnsSortedArray()
    {
        int[] array = new int[] { 5, 4, 3, 2, 1 };
        int operationCount = 0;

        int[] sortedArray = BubleSort.Sort(array, ref operationCount);

        Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, sortedArray);
    }

    [Fact]
    public void Sort_UnsortedArray_ReturnsSortedArray()
    {
        int[] array = new int[] { 3, 1, 4, 1, 5, 9, 2, 6 };
        int operationCount = 0;

        int[] sortedArray = BubleSort.Sort(array, ref operationCount);

        Assert.Equal(new int[] { 1, 1, 2, 3, 4, 5, 6, 9 }, sortedArray);
    }

    [Fact]
    public void Sort_SingleElementArray_ReturnsSameArray()
    {
        int[] array = new int[] { 42 };
        int operationCount = 0;

        int[] sortedArray = BubleSort.Sort(array, ref operationCount);

        Assert.Equal(new int[] { 42 }, sortedArray);
    }

    [Fact]
    public void OptimizedSort_UnsortedArray_ReturnsSortedArray()
    {
        int[] array = new int[] { 3, 1, 4, 1, 5, 9, 2, 6 };
        int operationCount = 0;

        int[] sortedArray = BubleSort.OptimizedSort(array, ref operationCount);

        Assert.Equal(new int[] { 1, 1, 2, 3, 4, 5, 6, 9 }, sortedArray);
    }

    [Fact]
    public void OptimizedSort_AlreadySortedArray_MinimizesOperations()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5 };
        int operationCount = 0;

        int[] sortedArray = BubleSort.OptimizedSort(array, ref operationCount);

        Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, sortedArray);
        Assert.True(operationCount < 10); // Daha az işlem yapılmalı
    }
}
