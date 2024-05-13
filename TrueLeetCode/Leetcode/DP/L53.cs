namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/maximum-subarray/
public class L53
{
    public int MaxSubArray(int[] nums)
    {
        int sum = int.MinValue;
        int currentSum = 0;

        foreach (var x in nums)
        {
            currentSum = Math.Max(x, currentSum + x);
            sum = Math.Max(sum, currentSum);
        }

        return sum;
    }
}
