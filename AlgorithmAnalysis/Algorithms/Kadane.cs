using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.Algorithms.MaxSubArrayAlgorithms
{
    public class Kadane
    {
        public static int FindMaxSubArray(int[] arr, ref int operationCount)
        {
            int maxSum = int.MinValue;
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                operationCount++;
                if (sum > maxSum)
                     maxSum = sum;
                if(sum < 0 )
                    sum = 0;
            }
            return maxSum;  

        }
    }
}
