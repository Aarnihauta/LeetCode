﻿namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/transpose-matrix/
public class L867
{
    public int[][] Transpose(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[][] result = new int[n][];

        for (int i = 0; i < n; i++)
        {
            result[i] = new int[m];
            for (int j = 0; j < m; j++)
            {
                result[i][j] = matrix[j][i];
            }
        }

        return result;
    }
}
