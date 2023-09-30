/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame
{

    // Solution: 
    // 1. https://leetcode.com/problems/guess-number-higher-or-lower/submissions/1062569872/
    // 2. https://leetcode.com/problems/guess-number-higher-or-lower/submissions/1062573551/
    public int GuessNumber(int n)
    {
        int left = 1; int right = n;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            int gs = guess(mid);

            switch (gs)
            {
                case 0: return mid;
                case -1:
                    right = mid - 1;
                    break;
                default:
                    left = mid + 1;
                    break;
            }
        }
        return right;
    }
}