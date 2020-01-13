using System;
using System.Collections.Generic;

namespace problemsolving
{
    public class DiagonalDifference
    {
        public DiagonalDifference()
        {
        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            int sumA=0;
            int sumB=0;
            for(int i = 0; i < arr.Count; i++)
            {
                sumA += arr[i][i];
                sumB -= arr[i][(arr.Count - 1) - i];
            }
            var a = Math.Abs(sumA) - Math.Abs(sumB);
            return a;
        }
    }
}
