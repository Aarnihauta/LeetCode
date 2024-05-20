namespace TrueLeetCode.Leetcode.BitManipulations;

//https://leetcode.com/problems/sum-of-all-subset-xor-totals/
public class L1863
{
    public int SubsetXORSum(int[] nums)
    {
        return Backtrack(nums, 0, 0);
    }

    private int Backtrack(int[] nums, int idx, int val)
    {
        if (idx >= nums.Length)
        {
            return val;
        }

        return Backtrack(nums, idx + 1, val ^ nums[idx]) + Backtrack(nums, idx + 1, val);
    }
}
