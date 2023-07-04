namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/house-robber
public class L198
{
    public int Rob(int[] nums)
    {
        int[] dp = new int[nums.Length + 1];

        dp[0] = 0;
        dp[1] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            dp[i + 1] = Math.Max(dp[i], nums[i - 1] + nums[i]);
        }

        return dp[^1];
    }
}
