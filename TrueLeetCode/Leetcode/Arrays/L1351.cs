namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/
public class L1351
{
    public int CountNegatives(int[][] grid)
    {
        int result = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            int r = grid[i].Length;

            if (grid[i][0] < 0)
            {
                result += r;
                continue;
            }
            int j = 0;
            while (j < r)
            {
                if (grid[i][j] >= 0)
                {
                    j++;
                }
                else
                {
                    result += r - j;
                    break;
                }
            }
        }

        return result;
    }
}
