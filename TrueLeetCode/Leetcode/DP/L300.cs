namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/longest-increasing-subsequence/
public class L300
{
    public int LengthOfLIS(int[] nums)
    {
        int n = nums.Length;
        int[] dp = new int[n];
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] > nums[j] && dp[i] < dp[j] + 1)
                {
                    dp[i] = dp[j] + 1;                
                }
            }
        }

        return dp.Max() + 1;
    }
}
