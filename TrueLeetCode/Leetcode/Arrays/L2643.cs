namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/row-with-maximum-ones/
public class L2643
{
    public int[] RowAndMaximumOnes(int[][] mat)
    {
        int max = 0;
        int k = 0;
        for (int i = 0; i < mat.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 1)
                {
                    count++;
                }
            }
            if(count > max)
            {
                max = count;
                k = i;
            }
        }

        return new int[] { k, max };
    }
}
