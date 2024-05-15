namespace TrueLeetCode.Leetcode.Backtracking;

//https://leetcode.com/problems/path-with-maximum-gold
public class L1219
{
    public int GetMaximumGold(int[][] grid)
    {
        int maxGold = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] != 0)
                {
                    maxGold = Math.Max(maxGold, DFS(grid, i, j));
                }
            }
        }

        return maxGold;
    }

    private int DFS(int[][] grid, int i, int j)
    {
        if (i >= grid.Length || j >= grid[0].Length || i < 0 || j < 0 || grid[i][j] == 0)
        {
            return 0;
        }

        int currentGold = grid[i][j];
        grid[i][j] = 0;
        int maxGold = 0;

        maxGold = Math.Max(currentGold, maxGold + DFS(grid, i + 1, j));
        maxGold = Math.Max(currentGold, maxGold + DFS(grid, i - 1, j));
        maxGold = Math.Max(currentGold, maxGold + DFS(grid, i, j + 1));
        maxGold = Math.Max(currentGold, maxGold + DFS(grid, i, j - 1));

        grid[i][j] = currentGold;

        return maxGold;
    }
}
