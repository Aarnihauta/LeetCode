namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/non-decreasing-array/
public class L665
{
    public bool CheckPossibility(int[] nums)
    {
        bool changed = false;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] <= nums[i + 1])
            {
                continue;
            }

            if (changed)
            {
                return false;
            }

            if(i == 0 || nums[i + 1] >= nums[i - 1])
            {
                nums[i] = nums[i + 1];
            }
            else
            {
                nums[i + 1] = nums[i];
            }

            changed = true;
        }

        return true;
    }
}
