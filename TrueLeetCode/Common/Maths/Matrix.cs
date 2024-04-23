namespace TrueLeetCode.DataStructure.Math;
public class Matrix2
{
    public static int[][] Transpose(int[][] matrix)
    {
        var result = new int[matrix[0].Length][];

        for (int i = 0; i < matrix[0].Length; i++)
        {
            result[i] = new int[matrix.Length];

            for (int j = 0; j < matrix.Length; j++)
            {
                result[i][j] = matrix[j][i];
            }
        }

        return result;
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

    public static void Multiply(int[][] matrix, int n)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                matrix[i][j] *= n;
            }
        }
    }

    public static void Display(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write($"{matrix[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}
