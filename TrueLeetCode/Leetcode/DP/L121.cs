namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
public class L121
{
    public int MaxProfit(int[] prices)
    {
        int profit = 0;
        int min = prices[0];
        foreach (var today in prices)
        {
            min = Math.Min(min, today);
            profit = Math.Max(profit, today - min);
        }

        return profit;
    }
}
