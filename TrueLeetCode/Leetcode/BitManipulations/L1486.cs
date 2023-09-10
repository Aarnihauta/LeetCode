namespace TrueLeetCode.Leetcode.BitManipulations;

//https://leetcode.com/problems/xor-operation-in-an-array/
public class L1486
{
    public int XorOperation(int n, int start)
    {
        int res = 0;
        for(int i = 0; i < n; i++)
        {
            int val = start + 2 * i;
            res ^= val;
        }
        return res;
    }
}
