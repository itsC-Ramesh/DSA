public class Solution
{
    //Solution: https://leetcode.com/problems/kth-missing-positive-number/submissions/1063062815/
    public int FindKthPositive(int[] arr, int k)
    {
        int currentNumber = 1;
        var missingCount = 0;
        for (int i = 1; missingCount < k;)
        {
            if (arr.Contains(i)) i++;
            else
            {
                i++; currentNumber = i; missingCount++;
            }
        }
        return currentNumber - 1;
    }

    //Solution2: https://leetcode.com/problems/kth-missing-positive-number/submissions/1063072364/
    public int FindKthPositive(int[] arr, int k)
    {
        int currentNumber = 0;
        int missingCount = 0;

        for (int i = 0; missingCount < k;)
        {
            currentNumber++;
            if (i < arr.Length && arr[i] == currentNumber)
                i++;
            else
            {
                missingCount++;
            }
        }
        return currentNumber;
    }

    //Solution: https://leetcode.com/problems/kth-missing-positive-number/submissions/1063076398/
    public int FindKthPositive(int[] arr, int k)
    {
        int currentNumber = 1;
        int missingCount = 0;
        int i = 0;

        while (missingCount < k)
        {
            if (i < arr.Length && arr[i] == currentNumber)
            {
                i++;
            }
            else
            {
                missingCount++;
            }
            currentNumber++;
        }
        return currentNumber - 1;
    }

    //Using BinarySearch
    public int FindKthPositive(int[] arr, int k)
    {

        var left = 0;
        var right = arr.Length - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (arr[mid] - mid - 1 < k)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left + k;
    }
}