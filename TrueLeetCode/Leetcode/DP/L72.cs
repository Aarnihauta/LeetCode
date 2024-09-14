namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/edit-distance
public class L72
{
    public int MinDistance(string word1, string word2)
    {
        int m = word1.Length;
        int n = word2.Length;

        int[,] dp = new int[m + 1, n + 1];

        for (int i = 0; i <= m; i++)
        {
            dp[i, 0] = i; // Deleting all characters from word1
        }
        for (int j = 0; j <= n; j++)
        {
            dp[0, j] = j; // Inserting all characters into word1
        }

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (word1[i - 1] == word2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1]; // No operation needed
                }
                else
                {
                    dp[i, j] += 1 + Math.Min(dp[i - 1, j], Math.Min(dp[i, j - 1], dp[i - 1, j - 1]));
                }
            }
        }

        return dp[m, n];
    }
}
