using System.Runtime.CompilerServices;

namespace Codility_MinAbsSumOfTwo
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            Array.Sort(A);
            int left = 0;
            int right = A.Length - 1;
            int minAbsSum = int.MaxValue;
            int N = A.Length;

            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                while (left <= right)
                {
                    int currentSum = A[left] + A[right];
                    minAbsSum = Math.Min(minAbsSum, Math.Abs(currentSum));
                    if (currentSum <= 0)
                        left++;
                    else
                        right--;
                }
            }

            return minAbsSum;
        }
    }
}
