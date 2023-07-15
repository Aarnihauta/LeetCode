namespace TrueLeetCode.Leetcode.BinarySearch;

//https://leetcode.com/problems/search-a-2d-matrix/
public class L74
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int n = matrix.Length;
        int m = matrix[0].Length;

        int l = 0;
        int r = m * n - 1;

        while (l <= r)
        {
            int mid = (l + r) / 2;
            int i = mid / m;
            int j = mid % m;

            int current = matrix[i][j];
            if(target == current)
            {
                return true;
            }
            
            if(target > current)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }

        return false;
    }
}
