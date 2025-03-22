
namespace AlgorithmAnalysis.Algorithms.SearchAlgorithms
{
    public class BinarySearch 
    {
        public static int Search(int[] arr, int target, ref int operationCount)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                operationCount++;

                if (arr[mid] == target)
                    return mid;

                operationCount++;

                if (arr[mid] < target)
                    low = mid + 1;
            
                else
                    high = mid - 1;

            }
            return -1;
        }
    }
}
