using TrueLeetCode.DataStructure.Math;

int[][] matrix = new int[][]
{
    new int[] {1,2, 3},
    new int[] {4,5,6},
    new int[] {7,8,9},
};

matrix = Matrix2.Transpose(matrix);

Matrix2.Display(matrix);