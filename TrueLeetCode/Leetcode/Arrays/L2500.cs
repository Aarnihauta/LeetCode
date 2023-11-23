namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/delete-greatest-value-in-each-row/
public class L2500
{
    public int DeleteGreatestValue(int[][] grid)
    {
        int result = 0;
        foreach (var item in grid)
        {
            Array.Sort(item);
        }
        int pos = 1;
        for (int i = 0; i < grid[0].Length; i++)
        {
            int max = 0;
            for (int j = 0; j < grid.Length; j++)
            {
                max = Math.Max(grid[j][^pos], max);
            }
            pos++;
            result += max;
        }

        return result;
    }
}
