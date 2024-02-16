namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/max-area-of-island/
public class L695
{
    private int _m;
    private int _n;
    public int MaxAreaOfIsland(int[][] grid)
    {
        _m = grid.Length;
        _n = grid[0].Length;
        int res = 0;
        for (int i = 0; i < _m; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                int c = 0;
                res = Math.Max(res, DFS(grid, i, j, ref c));
            }
        }

        return res;
    }

    private int DFS(int[][] grid, int i, int j, ref int c)
    {
        if (i >= 0 && j >= 0 && i < _m && j < _n && grid[i][j] == 1 )
        {
            grid[i][j] = 0;
            c++;
            DFS(grid, i + 1, j, ref c);
            DFS(grid, i - 1, j, ref c);
            DFS(grid, i, j + 1, ref c);
            DFS(grid, i, j - 1, ref c);

        }
        return c;
    }
}
