namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/richest-customer-wealth/
public class L1672
{
    public int MaximumWealth(int[][] accounts)
    {
        int max = 0;
        for(int i = 0; i < accounts.Length; i++)
        {
            int sum = 0;
            for(int j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
            }
            max = Math.Max(max, sum);
        }
        return max;
    }
}
