using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.Algorithms.MaxSubArrayAlgorithms
{
    public class DivideAndConquer
    {
        public static int FindMaxSubArray(int[] arr, ref int operationCount)
        {
            return MaxSum(arr, 0, arr.Length - 1, ref operationCount);
        }

        private static int MaxSum(int[] arr, int left, int right, ref int operationCount)
        {
            operationCount++;
            if (left == right)
                return arr[left]; 

            int mid = (left + right) / 2;

     
            int leftMax = MaxSum(arr, left, mid, ref operationCount);
            int rightMax = MaxSum(arr, mid + 1, right, ref operationCount);
            int crossMax = MaxCrossingSum(arr, left, mid, right, ref operationCount);


            return Math.Max(leftMax, Math.Max(rightMax, crossMax));
        }

        private static int MaxCrossingSum(int[] arr, int left, int mid, int right, ref int operationCount)
        {
            int sum = 0;
            int leftSum = int.MinValue;

   
            for (int i = mid; i >= left; i--)
            {
                sum += arr[i];
                operationCount++;
                leftSum = Math.Max(leftSum, sum);
            }

            sum = 0;
            int rightSum = int.MinValue;


            for (int i = mid + 1; i <= right; i++)
            {
                sum += arr[i];
                operationCount++;
                rightSum = Math.Max(rightSum, sum);
            }

            return leftSum + rightSum; 
        }
    }
}
