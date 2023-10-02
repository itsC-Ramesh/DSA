public class Solution
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        int left = 0; int right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] > arr[mid + 1])
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
}