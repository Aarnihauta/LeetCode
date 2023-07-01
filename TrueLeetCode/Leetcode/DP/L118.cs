namespace TrueLeetCode.Leetcode.DP;
public class L118
{
    public IList<IList<int>> Generate(int numRows)
    {
        var dp = new int[numRows][];

        dp[0] = new int[] { 1 };
         
        for (int i = 1; i < numRows; i++)
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

        return dp;
    }
}
