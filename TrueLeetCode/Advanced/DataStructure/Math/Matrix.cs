namespace TrueLeetCode.Advanced.DataStructure.Math;
public class Matrix2
{
    public static void Rotate(int[][] matrix, int angle)
    {
    }

    public static int[][] Multiply(int[][] a, int[][] b)
    {
        int l = a.Length;
        int r = b[0].Length;
        int m = b.Length;

        int[][] result = new int[l][];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = new int[r];
        }

        for (int i = 0; i < l; i++)
        {
            for (int j = 0; j < r; j++)
            {
                for (int k = 0; k < m; k++)
                {
                    result[i][j] += a[i][k] * b[k][j];
                }
            }
        }
        return result;
    }
}
