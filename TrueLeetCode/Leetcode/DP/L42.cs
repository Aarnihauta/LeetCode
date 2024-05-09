namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/trapping-rain-water/
public class L42
{
    public int Trap(int[] height)
    {
        int l = 0;
        int r = height.Length - 1;
        int leftMax = 0;
        int rightMax = 0;
        int total = 0;

        while (l < r)
        {
            if (height[l] < height[r])
            {
                if (height[l] >= leftMax)
                {
                    leftMax = height[l];
                }
                else
                {
                    total += leftMax - height[l];
                }
                l++;
            }
            else
            {
                if (height[r] >= rightMax)
                {
                    rightMax = height[r];
                }
                else
                {
                    total += rightMax - height[r];
                }
                r--;
            }
        }

        return total;
    }
}
