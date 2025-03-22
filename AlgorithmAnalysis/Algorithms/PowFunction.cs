using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis.Algorithms.PowFuncitonAlgorithms
{
    public class PowFunction
    {
        public static int Iterative(int x, int y, out int operationCount)
        {
            int result = 1;
            operationCount = 0;
            for(int i = 0; i < y; i++)
            {
                operationCount++;
                result *= x;
            }
            return result;
        } 
        public static int Recursive(int x, int y, ref int operationCount)
        {

           operationCount++;
            if (y == 0)
                return 1;
            if (y%2 == 1) 
                return x * Recursive(x, y-1, ref operationCount);
            
            int half = Recursive(x, y / 2, ref operationCount);
            return half * half;

        }
    } 
}
