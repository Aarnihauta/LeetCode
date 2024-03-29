﻿namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/pascals-triangle-ii/
public class L119
{
    public IList<int> GetRow(int rowIndex)
    {
        var dp = new int[rowIndex + 1][];

        dp[0] = new int[] { 1 };

        for (int i = 1; i < rowIndex + 1; i++)
        {
            int k = dp[i - 1].Length;
            dp[i] = new int[k + 1];
            dp[i][0] = 1;
            dp[i][k] = 1;

            for (int j = 1; j < k; j++)
            {
                dp[i][j] = dp[i - 1][j] + dp[i - 1][j - 1];
            }
        }

        return dp[rowIndex];
    }
}
