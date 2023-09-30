public class Solution
{
    // Binary Search
    // https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/submissions/1062598023/
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 1; int right = numbers.Length;

        while (left <= right)
        {
            int x = numbers[left - 1] + numbers[right - 1];

            if (x == target) break;
            else if (x > target) right--;
            else left++;
        }
        return new int[] { left, right };
    }

    // Two Pointer
    // https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/submissions/1062601562/
    public int[] TwoSum(int[] numbers, int target)
    {
        for (int i = 1, j = numbers.Length; i < j;)
        {
            if (numbers[i - 1] + numbers[j - 1] == target)
                return new int[] { i, j };
            else if (numbers[i - 1] + numbers[j - 1] > target) j--;
            else i++;
        }
        return new int[] { 0, 0 };
    }
}