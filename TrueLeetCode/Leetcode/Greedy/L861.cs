
namespace TrueLeetCode.Leetcode.Greedy;

//https://leetcode.com/problems/score-after-flipping-matrix
public class L861
{
    public int MatrixScore(int[][] grid)
    {
        int sum = 0;
        int m = grid.Length;
        int n = grid[0].Length;

        for (int i = 0; i < m; i++)
        {
            if (grid[i][0] == 0)
            {
                ReverseRow(grid, i);
            }
        }

        for (int i = 1; i < n; i++)
        {
            int cnt = 0;

            for (int j = 0; j < m; j++)
            {
                cnt += grid[j][i];
            }

            if (cnt < m - cnt)
            {
                ReverseColumn(grid, i);
            }
        }

        for (int i = 0; i < m; i++)
        {
            int val = 0;

            for (int j = 0; j < n; j++)
            {
                val <<= 1;
                val += grid[i][j];
            }
            sum += val;
        }

        return sum;
    }

    private void ReverseColumn(int[][] grid, int col)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            grid[i][col] = 1 - grid[i][col];
        }
    }

    private void ReverseRow(int[][] grid, int row)
    {
        for (int i = 0; i < grid[0].Length; i++)
        {
            grid[row][i] = 1 - grid[row][i];
        }
    }
}
