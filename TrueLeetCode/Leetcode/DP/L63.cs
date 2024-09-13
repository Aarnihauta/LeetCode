namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/unique-paths-iik
public class L63
{
    public int UniquePathsWithObstacles(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        int[,] dp = new int[m, n];
        dp[0, 0] = 1;
        if (grid[m - 1][n - 1] == 1 || grid[0][0] == 1)
        {
            return 0;
        }

        for (int i = 1; i < m; i++)
        {
            if (grid[i][0] == 0)
            {
                dp[i, 0] = dp[i - 1, 0];
            }
        }

        for (int i = 1; i < n; i++)
        {
            if (grid[0][i] == 0)
            {
                dp[0, i] = dp[0, i - 1];
            }
        }

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (grid[i][j] == 0)
                {
                    dp[i, j] += dp[i - 1, j] + dp[i, j - 1];
                }
            }
        }

        return dp[m - 1, n - 1];
    }
}
