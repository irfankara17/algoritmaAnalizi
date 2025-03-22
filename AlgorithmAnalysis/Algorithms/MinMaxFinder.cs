using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.Algorithms.SearchAlgorithms
{
    public class MinMaxFinder
    {
        public static int Min(int[] arr, ref int operationCount)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                operationCount++;
                if (arr[i] < min)
                    min = arr[i];   
            }

            return min; 
        }
        public static int Max(int[] arr,ref int operationCount)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                operationCount++;
                if (arr[i] > max)
                    max = arr[i];   
            }

            return max; 
        }
    }
}
