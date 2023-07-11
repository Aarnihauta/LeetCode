namespace TrueLeetCode.Leetcode.Greedy;

//https://leetcode.com/problems/container-with-most-water/
public class L11
{
    public int MaxArea(int[] height)
    {
        int max = 0;
        int l = 0;
        int r = height.Length - 1;

        while (l < r)
        {
            var area = (r - l) * Math.Min(height[l], height[r]);

            if (height[l] < height[r])
            {
                l++;
            }
            else
            {
                r--;
            }

            max = Math.Max(max, area);
        }

        return max;
    }
}
