public class Solution
{
    public bool Find132pattern(int[] nums)
    {
        if (nums.Length < 3) return false;

        int n = nums.Length;
        int[] leftMin = new int[n];
        leftMin[0] = nums[0];

        for (int i = 1; i < n; i++)
        {
            leftMin[i] = Math.Min(leftMin[i - 1], nums[i]);
        }

        Stack<int> stack = new Stack<int>();

        for (int j = n - 1; j >= 0; j--)
        {
            if (nums[j] > leftMin[j])
            {
                while (stack.Count > 0 && stack.Peek() <= leftMin[j])
                {
                    stack.Pop();
                }

                if (stack.Count > 0 && stack.Peek() < nums[j])
                {
                    return true;
                }

                stack.Push(nums[j]);
            }
        }

        return false;
    }
}
