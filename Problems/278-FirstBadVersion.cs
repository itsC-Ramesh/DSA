/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl
{
    //Solution: https://leetcode.com/problems/first-bad-version/submissions/1062583808/
    public int FirstBadVersion(int n)
    {
        int left = 1; int right = n;

        while (left < right)
        {
            int midVersion = left + (right - left) / 2;
            bool isBad = IsBadVersion(midVersion);

            if (!isBad) left = midVersion + 1;
            else right = midVersion;
        }
        return left;
    }
}