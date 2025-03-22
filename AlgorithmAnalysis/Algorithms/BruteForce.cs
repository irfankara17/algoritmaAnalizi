using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.Algorithms.MaxSubArrayAlgorithms
{
    public class BruteForce
    {
        // O(n^3)
        public static int FirstBruteForce(int[] arr, ref int operationCount)
        {
            int n = arr.Length;
            int maxSum = int.MinValue; 

            for (int start = 0; start < n; start++)  
            {
                for (int end = start; end < n; end++) 
                {
                    int sum = 0;
                    for (int k = start; k <= end; k++) 
                    {
                        sum += arr[k];
                        operationCount++;
                    }
                    maxSum = Math.Max(maxSum, sum); 
                }
            }

            return maxSum; 
        }

        // O(n^2)
        public static int SecondBruteForce(int[] arr, ref int operationCount)
        {
            int n = arr.Length;
            int maxSum = int.MinValue;

            for (int start = 0; start < n; start++)
            {
                int sum = 0; 
                for (int end = start; end < n; end++)
                {
                    sum += arr[end];
                    operationCount++;
                    maxSum = Math.Max(maxSum, sum);
                }
            }

            return maxSum;
        }
    }

}
