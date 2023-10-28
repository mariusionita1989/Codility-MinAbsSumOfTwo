using Codility_MinAbsSumOfTwo;

namespace Codility_MinAbsSumOfTwoTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestBasicCase()
        {
            Solution solution = new Solution();
            int[] A = { 1, 4, -3 };
            int expected = 1;
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestNegativeNumbers()
        {
            Solution solution = new Solution();
            int[] A = { -8, 4, 5, -10, 3 };
            int expected = 3;
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAllPositiveNumbers()
        {
            Solution solution = new Solution();
            int[] A = { 2, 5, 7, 9 };
            int expected = 4;
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAllNegativeNumbers()
        {
            Solution solution = new Solution();
            int[] A = { -5, -3, -1, -7 };
            int expected = 2;
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSingleElementArray()
        {
            Solution solution = new Solution();
            int[] A = { 42 };
            int expected = 84;
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestLargeRange()
        {
            Solution solution = new Solution();
            int[] A = new int[Solution.RANGE_HIGHEST_VALUE];
            for (int i = 0; i < A.Length; i++)
                A[i] = i;
            int expected = 0;
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }
    }
}