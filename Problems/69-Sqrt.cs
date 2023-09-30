public class Solution
{
    //Brute Force
    public int MySqrt(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            int square = i * i;
            if (square == x) return i;
            if (square > x) return i - 1;
        }
        return x;
    }

    //Binary Search
    //Solution: https://leetcode.com/problems/sqrtx/submissions/1062559176/
    public int MySqrt(int x)
    {
        if (x == 0 || x == 1) return x;

        int left = 1;
        int right = x;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            long square = (long)mid * mid;

            if (square == x) return mid;
            else if (square < x) left = mid + 1;
            else right = mid - 1;
        }
        return right;
    }
}