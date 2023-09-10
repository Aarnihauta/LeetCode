namespace TrueLeetCode.Leetcode.BitManipulations;

//https://leetcode.com/problems/find-the-original-array-of-prefix-xor/
public class L2433
{
    public int[] FindArray(int[] pref)
    {
        int[] result = new int[pref.Length];
        result[0] = pref[0];
        for (int i = 1; i < pref.Length; i++)
        {
            result[i] = pref[i] ^ pref[i - 1];
        }
        return result;
    }
}
