namespace TrueLeetCode.Leetcode.BitManipulations;
public class L191
{
    public int HammingWeight(uint n)
    {
        uint result = 0;

        while(n != 0)
        {
            result += n & 1;
            n >>= 1;
        }

        return (int)result;
    }
}
