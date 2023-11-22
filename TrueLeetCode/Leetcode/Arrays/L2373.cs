namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/largest-local-values-in-a-matrix/
public class L2373
{
    public int[][] LargestLocal(int[][] grid)
    {
        int n = grid.Length;
        int k = n - 2;
        int[][] result = new int[k][];

        int offsetLeft = 0;
        int offsetTop = 0;

        for (int i = 0; i < k; i++)
        {
            result[i] = new int[k];
            for (int j = 0; j < k; j++)
            {
                result[i][j] = GetMax(grid, offsetLeft++, offsetTop);
            }

            offsetLeft = 0;
            offsetTop++;
        }

        return result;
    }

    private int GetMax(int[][] grid, int offsetLeft, int offsetTop)
    {
        int n = 3;
        int max = 0;

        for (int i = offsetTop; i < n + offsetTop; i++)
        {
            for (int j = offsetLeft; j < n + offsetLeft; j++)
            {
                max = Math.Max(max, grid[i][j]);
            }
        }

        return max;
    }
}
