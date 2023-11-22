namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/matrix-diagonal-sum/
public class L1572
{
    public int DiagonalSum(int[][] mat)
    {
        int m = mat.Length;
        int sum = 0;
        for (int i = 0; i < m; i++)
        {
            int r = m - i - 1;
            if (r != i)
            {
                sum += mat[i][r];
            }
            sum += mat[i][i];
        }

        return sum;
    }
}
