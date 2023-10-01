public class Solution
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        int left = 0;
        int right = letters.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (letters[mid] > target) right = mid - 1;
            else left = mid + 1;
        }
        if (left < letters.Length) return letters[left];
        else return letters[0];
    }
}