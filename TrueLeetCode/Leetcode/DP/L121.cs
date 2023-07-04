namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
public class L121
{
    public int MaxProfit(int[] prices)
    {
        var min = prices[0];
        var profit = 0;
        foreach (var today in prices)
        {
            profit = Math.Max(profit, today - min);
            min = Math.Min(min, today);
        }
        return profit;
    }
}
