namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/jump-game-ii
public class L45
{

    public int Jump(int[] nums)
    {
        int n = nums.Length;
        if (n < 1)
        {
            return 1;
        }

        int result = 0;
        int maxEnd = 0;
        int currEnd = 0;

        for (int i = 0; i < n; i++)
        {
            maxEnd = Math.Max(maxEnd, i + nums[i]);

            if(i == currEnd)
            {
                result++;
                currEnd = maxEnd;

                if (currEnd >= n - 1)
                {
                    return result;
                }
            }
        }

        return result;
    }
}
