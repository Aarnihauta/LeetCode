namespace TrueLeetCode.Leetcode.Common;

//https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
public class L153
{
    public int FindMin(int[] nums)
    {
        int l = 0;
        int r = nums.Length - 1;

        while (l < r)
        {
            int mid = l + (r - l) / 2;
            if (nums[mid] > nums[r])
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }

        return nums[l];
    }
}
