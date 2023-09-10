namespace TrueLeetCode.Leetcode.BitManipulations;

//https://leetcode.com/problems/decode-xored-array/
public class L1720
{
    public int[] Decode(int[] encoded, int first)
    {
        int[] decoded = new int[encoded.Length + 1];
        decoded[0] = first;
        for(int i = 1; i < decoded.Length; i++)
        {
            decoded[i] = encoded[i-1] ^ decoded[i-1];
        }

        return decoded;
    }
}
