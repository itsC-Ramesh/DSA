public class Solution
{
    // Solution: https://leetcode.com/problems/valid-perfect-square/submissions/1062613621/
    // Binary Search
    public bool IsPerfectSquare(int num)
    {
        if (num == 1) return true;
        int left = 1; int right = num;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            var sqr = (long)mid * mid;
            if (sqr == num) return true;
            else if (sqr > num) right = mid - 1;
            else left = mid + 1;
        }
        return false;
    }
}