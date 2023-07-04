namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/climbing-stairs/
internal class L70
{
    public int ClimbStairs(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        if (n == 2)
        {
            return 2;
        }

        int p1 = 1;
        int p2 = 2;
        int res = 0;
        for (int i = 2; i < n; i++)
        {
            res = p1 + p2;
            p1 = p2;
            p2 = res;
        }

        return res;
    }
}
