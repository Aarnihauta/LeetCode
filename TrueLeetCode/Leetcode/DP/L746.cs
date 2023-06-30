namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/min-cost-climbing-stairs/
public class L746
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int l = cost.Length;

        for (int i = 2; i < cost.Length; i++)
        {
            cost[i] += Math.Min(cost[i - 1], cost[i - 2]);
        }

        return Math.Min(cost[l - 1], cost[l - 2]);
    }
}
