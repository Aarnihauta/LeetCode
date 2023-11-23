namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/flipping-an-image/
public class L832
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        int m = image.Length;

        for (int i = 0; i < m; i++)
        {
            int l = 0;
            int r = m - 1;
            while (l <= r)
            {
                int leftValue = image[i][l] > 0 ? 0 : 1;
                int rightValue = image[i][r] > 0 ? 0 : 1;
                image[i][l] = rightValue;
                image[i][r] = leftValue;
                l++;
                r--;
            }
        }

        return image;
    }
}
