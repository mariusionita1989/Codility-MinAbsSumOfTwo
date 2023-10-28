# Codility-MinAbsSumOfTwo
Let A be a non-empty array consisting of N integers.</br>
The abs sum of two for a pair of indices (P, Q) is the absolute value |A[P] + A[Q]|, for 0 ≤ P ≤ Q < N.

For example, the following array A:</br>
A[0] =  1</br>
A[1] =  4</br>
A[2] = -3</br>
has pairs of indices (0, 0), (0, 1), (0, 2), (1, 1), (1, 2), (2, 2).</br>
The abs sum of two for the pair (0, 0) is A[0] + A[0] = |1 + 1| = 2.</br>
The abs sum of two for the pair (0, 1) is A[0] + A[1] = |1 + 4| = 5.</br>
The abs sum of two for the pair (0, 2) is A[0] + A[2] = |1 + (−3)| = 2.</br>
The abs sum of two for the pair (1, 1) is A[1] + A[1] = |4 + 4| = 8.</br>
The abs sum of two for the pair (1, 2) is A[1] + A[2] = |4 + (−3)| = 1.</br>
The abs sum of two for the pair (2, 2) is A[2] + A[2] = |(−3) + (−3)| = 6.

Write a function:</br>
class Solution { public int solution(int[] A); }</br>
that, given a non-empty array A consisting of N integers, returns the minimal abs sum of two for any pair of indices in this array.

For example, given the following array A:</br>
A[0] =  1</br>
A[1] =  4</br>
A[2] = -3</br>
the function should return 1, as explained above.

Given array A:</br>
A[0] = -8</br>
A[1] =  4</br>
A[2] =  5</br>
A[3] =-10</br>
A[4] =  3</br>
the function should return |(−8) + 5| = 3.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [1..100,000];</br>
each element of array A is an integer within the range [−1,000,000,000..1,000,000,000].
