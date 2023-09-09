namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/counting-bits/description/
public class L338
{
    public int[] CountBits(int n)
    {
        int[] res = new int[n + 1];
        for (int i = 0; i < n + 1; i++)
        {
            res[i] = HammingWeight(i);
        }

        return res;
    }

    private int HammingWeight(int n)
    {
        int res = 0;
        while (n != 0)
        {
            res += n & 1;
            n = n >> 1;
        }
        return res;
    }
}
